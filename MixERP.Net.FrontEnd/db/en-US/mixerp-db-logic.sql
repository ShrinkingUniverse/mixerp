DROP FUNCTION IF EXISTS core.is_leap_year(integer);
CREATE FUNCTION core.is_leap_year(integer)
RETURNS boolean
AS
$$
BEGIN
	RETURN (SELECT date_part('day', (($1::text || '-02-01')::date + '1 month'::interval - '1 day'::interval)) = 29);
END
$$
LANGUAGE plpgsql
IMMUTABLE STRICT;

DROP FUNCTION IF EXISTS core.get_current_year();
CREATE FUNCTION core.get_current_year()
RETURNS integer
AS
$$
BEGIN
	RETURN(SELECT EXTRACT(year FROM current_date)::integer);
END
$$
LANGUAGE plpgsql;

DROP FUNCTION IF EXISTS core.is_leap_year();
CREATE FUNCTION core.is_leap_year()
RETURNS boolean
AS
$$
BEGIN
	RETURN core.is_leap_year(core.get_current_year());
END
$$
LANGUAGE plpgsql
IMMUTABLE STRICT;

DROP FUNCTION IF EXISTS core.calculate_interest(principal numeric, rate numeric, days integer, num_of_days_in_year integer, round_up integer);
CREATE FUNCTION core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer, num_of_days_in_year integer)
RETURNS numeric
AS
$$
	DECLARE interest numeric;
BEGIN
	IF num_of_days_in_year = 0 OR num_of_days_in_year IS NULL THEN
		RAISE EXCEPTION 'Cannot calculate interest. The number of days in a year was not provided.';
	END IF;
	
	interest := ROUND(principal * rate * days / (num_of_days_in_year * 100), round_up);

	RETURN interest;
END
$$
LANGUAGE plpgsql
IMMUTABLE STRICT;


DROP FUNCTION IF EXISTS core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer);
CREATE FUNCTION core.calculate_interest(principal numeric, rate numeric, days integer, round_up integer)
RETURNS numeric
AS
$$
	DECLARE num_of_days_in_year integer = 365;
BEGIN
	IF core.is_leap_year() THEN
		num_of_days_in_year = 366;
	END IF;
	
	RETURN core.calculate_interest(principal, rate, days, round_up, num_of_days_in_year);
END
$$
LANGUAGE plpgsql
IMMUTABLE STRICT;

DROP FUNCTION IF EXISTS office.can_login(user_id integer_strict, office_id integer_strict);
CREATE FUNCTION office.can_login(user_id integer_strict, office_id integer_strict)
RETURNS boolean
AS
$$
DECLARE _office_id integer;
BEGIN
	_office_id:=office.get_office_id_by_user_id($1);

	IF $1 = office.get_sys_user_id() THEN
		RETURN false;
	END IF;

	IF $2=_office_id THEN
		RETURN true;
	ELSE
		IF office.is_parent_office(_office_id,$2) THEN
			RETURN true;
		END IF;
	END IF;
	RETURN false;
END;
$$
LANGUAGE plpgsql;


DROP FUNCTION IF EXISTS office.sign_in(office_id integer_strict, user_name text, password text, browser text, ip_address text, remote_user text, culture text);
CREATE FUNCTION office.sign_in(office_id integer_strict, user_name text, password text, browser text, ip_address text, remote_user text, culture text)
RETURNS integer
AS
$$
	DECLARE _user_id integer;
	DECLARE _lock_out_till TIMESTAMP;
BEGIN
	_user_id:=office.get_user_id_by_user_name($2);

	IF _user_id IS NULL THEN
		INSERT INTO audit.failed_logins(user_name,browser,ip_address,remote_user,details)
		SELECT $2, $4, $5, $6, 'Invalid user name.';
	ELSE
		_lock_out_till:=policy.is_locked_out_till(_user_id);
		IF NOT ((_lock_out_till IS NOT NULL) AND (_lock_out_till>NOW())) THEN
			IF office.validate_login($2,$3) THEN
				IF office.can_login(_user_id,$1) THEN
					INSERT INTO audit.logins(office_id,user_id,browser,ip_address,remote_user, culture)
					SELECT $1, _user_id, $4, $5, $6, $7;

					RETURN CAST(currval('audit.logins_login_id_seq') AS integer);
				ELSE
					INSERT INTO audit.failed_logins(office_id,user_id,user_name,browser,ip_address,remote_user,details)
					SELECT $1, _user_id, $2, $4, $5, $6, 'User from ' || office.get_office_name_by_id(office.get_office_id_by_user_id(_user_id)) || ' cannot login to ' || office.get_office_name_by_id($1) || '.';
				END IF;
			ELSE
				INSERT INTO audit.failed_logins(office_id,user_id,user_name,browser,ip_address,remote_user,details)
				SELECT $1, _user_id, $2, $4, $5, $6, 'Invalid login attempt.';
			END IF;
		END IF;
	END IF;

	RETURN 0;
END
$$
LANGUAGE plpgsql;




DROP FUNCTION IF EXISTS core.get_item_cost_price(item_id_ integer, party_id_ integer, unit_id_ integer);
CREATE FUNCTION core.get_item_cost_price(item_id_ integer, party_id_ integer, unit_id_ integer)
RETURNS money
AS
$$
	DECLARE _price money;
	DECLARE _unit_id integer;
	DECLARE _factor decimal;
	DECLARE _tax_rate decimal;
	DECLARE _includes_tax boolean;
	DECLARE _tax money;
BEGIN

	--Fist pick the catalog price which matches all these fields:
	--Item, Customer Type, Price Type, and Unit.
	--This is the most effective price.
	SELECT 
		item_cost_prices.price, 
		item_cost_prices.unit_id,
		item_cost_prices.includes_tax
	INTO 
		_price, 
		_unit_id,
		_includes_tax		
	FROM core.item_cost_prices
	WHERE item_cost_prices.item_id=$1
	AND item_cost_prices.party_id=$2
	AND item_cost_prices.unit_id = $3;

	IF(_unit_id IS NULL) THEN
		--We do not have a cost price of this item for the unit supplied.
		--Let's see if this item has a price for other units.
		SELECT 
			item_cost_prices.price, 
			item_cost_prices.unit_id,
			item_cost_prices.includes_tax
		INTO 
			_price, 
			_unit_id,
			_includes_tax
		FROM core.item_cost_prices
		WHERE item_cost_prices.item_id=$1
		AND item_cost_prices.party_id=$2;
	END IF;

	
	IF(_price IS NULL) THEN
		--This item does not have cost price defined in the catalog.
		--Therefore, getting the default cost price from the item definition.
		SELECT 
			cost_price, 
			unit_id,
			cost_price_includes_tax
		INTO 
			_price, 
			_unit_id,
			_includes_tax
		FROM core.items
		WHERE core.items.item_id = $1;
	END IF;

	IF(_includes_tax) THEN
		_tax_rate := core.get_item_tax_rate($1);
		_price := _price / ((100 + _tax_rate)/ 100);
	END IF;

	--Get the unitary conversion factor if the requested unit does not match with the price defition.
	_factor := core.convert_unit($3, _unit_id);

	RETURN _price * _factor;
END
$$
LANGUAGE plpgsql;

DROP FUNCTION IF EXISTS core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer);
CREATE FUNCTION core.get_item_selling_price(item_id_ integer, party_type_id_ integer, price_type_id_ integer, unit_id_ integer)
RETURNS money
AS
$$
	DECLARE _price money;
	DECLARE _unit_id integer;
	DECLARE _factor decimal;
	DECLARE _tax_rate decimal;
	DECLARE _includes_tax boolean;
	DECLARE _tax money;
BEGIN

	--Fist pick the catalog price which matches all these fields:
	--Item, Customer Type, Price Type, and Unit.
	--This is the most effective price.
	SELECT 
		item_selling_prices.price, 
		item_selling_prices.unit_id,
		item_selling_prices.includes_tax
	INTO 
		_price, 
		_unit_id,
		_includes_tax		
	FROM core.item_selling_prices
	WHERE item_selling_prices.item_id=$1
	AND item_selling_prices.party_type_id=$2
	AND item_selling_prices.price_type_id =$3
	AND item_selling_prices.unit_id = $4;

	IF(_unit_id IS NULL) THEN
		--We do not have a selling price of this item for the unit supplied.
		--Let's see if this item has a price for other units.
		SELECT 
			item_selling_prices.price, 
			item_selling_prices.unit_id,
			item_selling_prices.includes_tax
		INTO 
			_price, 
			_unit_id,
			_includes_tax
		FROM core.item_selling_prices
		WHERE item_selling_prices.item_id=$1
		AND item_selling_prices.party_type_id=$2
		AND item_selling_prices.price_type_id =$3;
	END IF;

	
	IF(_price IS NULL) THEN
		--This item does not have selling price defined in the catalog.
		--Therefore, getting the default selling price from the item definition.
		SELECT 
			selling_price, 
			unit_id,
			selling_price_includes_tax
		INTO 
			_price, 
			_unit_id,
			_includes_tax
		FROM core.items
		WHERE core.items.item_id = $1;
	END IF;

	IF(_includes_tax) THEN
		_tax_rate := core.get_item_tax_rate($1);
		_price := _price / ((100 + _tax_rate)/ 100);
	END IF;

	--Get the unitary conversion factor if the requested unit does not match with the price defition.
	_factor := core.convert_unit($4, _unit_id);

	RETURN _price * _factor;
END
$$
LANGUAGE plpgsql;

DROP FUNCTION IF EXISTS transactions.verification_trigger() CASCADE;
CREATE FUNCTION transactions.verification_trigger()
RETURNS TRIGGER
AS
$$
	DECLARE _transaction_master_id bigint;
	DECLARE _transaction_posted_by integer;
	DECLARE _old_verifier integer;
	DECLARE _old_status integer;
	DECLARE _old_reason national character varying(128);
	DECLARE _verifier integer;
	DECLARE _status integer;
	DECLARE _reason national character varying(128);
	DECLARE _has_policy boolean;
	DECLARE _is_sys boolean;
	DECLARE _rejected smallint=-3;
	DECLARE _closed smallint=-2;
	DECLARE _withdrawn smallint=-1;
	DECLARE _unapproved smallint = 0;
	DECLARE _auto_approved smallint = 1;
	DECLARE _approved smallint=2;
	DECLARE _book text;
	DECLARE _can_verify_sales_transactions boolean;
	DECLARE _sales_verification_limit money;
	DECLARE _can_verify_purchase_transactions boolean;
	DECLARE _purchase_verification_limit money;
	DECLARE _can_verify_gl_transactions boolean;
	DECLARE _gl_verification_limit money;
	DECLARE _can_verify_self boolean;
	DECLARE _self_verification_limit money;
	DECLARE _posted_amount money;
BEGIN
	IF TG_OP='DELETE' THEN
		RAISE EXCEPTION 'Deleting a transaction is not allowed. Mark the transaction as rejected instead.';
	END IF;

	IF TG_OP='UPDATE' THEN
		RAISE NOTICE 'Columns except the following will be ignored for this update: verified_by_user_id, verification_status_id, verification_reason.';

		IF(OLD.transaction_master_id IS DISTINCT FROM NEW.transaction_master_id) THEN
			RAISE EXCEPTION 'Cannot update the column "transaction_master_id".';
		END IF;

		IF(OLD.transaction_counter IS DISTINCT FROM NEW.transaction_counter) THEN
			RAISE EXCEPTION 'Cannot update the column "transaction_counter".';
		END IF;

		IF(OLD.transaction_code IS DISTINCT FROM NEW.transaction_code) THEN
			RAISE EXCEPTION 'Cannot update the column "transaction_code".';
		END IF;

		IF(OLD.book IS DISTINCT FROM NEW.book) THEN
			RAISE EXCEPTION 'Cannot update the column "book".';
		END IF;

		IF(OLD.value_date IS DISTINCT FROM NEW.value_date) THEN
			RAISE EXCEPTION 'Cannot update the column "value_date".';
		END IF;

		IF(OLD.transaction_ts IS DISTINCT FROM NEW.transaction_ts) THEN
			RAISE EXCEPTION 'Cannot update the column "transaction_ts".';
		END IF;

		IF(OLD.login_id IS DISTINCT FROM NEW.login_id) THEN
			RAISE EXCEPTION 'Cannot update the column "login_id".';
		END IF;

		IF(OLD.user_id IS DISTINCT FROM NEW.user_id) THEN
			RAISE EXCEPTION 'Cannot update the column "user_id".';
		END IF;

		IF(OLD.sys_user_id IS DISTINCT FROM NEW.sys_user_id) THEN
			RAISE EXCEPTION 'Cannot update the column "sys_user_id".';
		END IF;

		IF(OLD.office_id IS DISTINCT FROM NEW.office_id) THEN
			RAISE EXCEPTION 'Cannot update the column "office_id".';
		END IF;

		IF(OLD.cost_center_id IS DISTINCT FROM NEW.cost_center_id) THEN
			RAISE EXCEPTION 'Cannot update the column "cost_center_id".';
		END IF;

		_transaction_master_id := OLD.transaction_master_id;
		_book := OLD.book;
		_old_verifier := OLD.verified_by_user_id;
		_old_status := OLD.verification_status_id;
		_old_reason := OLD.verification_reason;
		_transaction_posted_by := OLD.user_id;		
		_verifier := NEW.verified_by_user_id;
		_status := NEW.verification_status_id;
		_reason := NEW.verification_reason;
		_is_sys := office.is_sys(_verifier);


		SELECT
			SUM(amount)
		INTO
			_posted_amount
		FROM
			transactions.transaction_details
		WHERE transactions.transaction_details.transaction_master_id = _transaction_master_id
		AND transactions.transaction_details.tran_type='Cr';


		SELECT
			true,
			can_verify_sales_transactions,
			sales_verification_limit,
			can_verify_purchase_transactions,
			purchase_verification_limit,
			can_verify_gl_transactions,
			gl_verification_limit,
			can_self_verify,
			self_verification_limit
		INTO
			_has_policy,
			_can_verify_sales_transactions,
			_sales_verification_limit,
			_can_verify_purchase_transactions,
			_purchase_verification_limit,
			_can_verify_gl_transactions,
			_gl_verification_limit,
			_can_verify_self,
			_self_verification_limit
		FROM
		policy.voucher_verification_policy
		WHERE user_id=_verifier
		AND is_active=true
		AND now() >= effective_from
		AND now() <= ends_on;

		IF(_verifier IS NULL) THEN
			RAISE EXCEPTION 'Access is denied.';
		END IF;		
		
		IF(_status != _withdrawn AND _has_policy = false) THEN
			RAISE EXCEPTION 'Access is denied. You don''t have the right to verify the transaction.';
		END IF;

		IF(_status = _withdrawn AND _has_policy = false) THEN
			IF(_transaction_posted_by != _verifier) THEN
				RAISE EXCEPTION 'Access is denied. You don''t have the right to withdraw the transaction.';
			END IF;
		END IF;

		IF(_status = _auto_approved AND _is_sys = false) THEN
			RAISE EXCEPTION 'Access is denied.';
		END IF;


		IF(_has_policy = false) THEN
			RAISE EXCEPTION 'Access is denied.';
		END IF;


		--Is trying verify self transaction.
		IF(NEW.verified_by_user_id = NEW.user_id) THEN
			IF(_can_verify_self = false) THEN
				RAISE EXCEPTION 'Please ask someone else to verify the transaction you posted.';
			END IF;
			IF(_can_verify_self = true) THEN
				IF(_posted_amount > _self_verification_limit AND _self_verification_limit > 0::money) THEN
					RAISE EXCEPTION 'Self verfication limit exceeded. The transaction was not verified.';
				END IF;
			END IF;
		END IF;

		IF(lower(_book) LIKE '%sales%') THEN
			IF(_can_verify_sales_transactions = false) THEN
				RAISE EXCEPTION 'Access is denied.';
			END IF;
			IF(_can_verify_sales_transactions = true) THEN
				IF(_posted_amount > _sales_verification_limit AND _sales_verification_limit > 0::money) THEN
					RAISE EXCEPTION 'Sales verfication limit exceeded. The transaction was not verified.';
				END IF;
			END IF;			
		END IF;


		IF(lower(_book) LIKE '%purchase%') THEN
			IF(_can_verify_purchase_transactions = false) THEN
				RAISE EXCEPTION 'Access is denied.';
			END IF;
			IF(_can_verify_purchase_transactions = true) THEN
				IF(_posted_amount > _purchase_verification_limit AND _purchase_verification_limit > 0::money) THEN
					RAISE EXCEPTION 'Purchase verfication limit exceeded. The transaction was not verified.';
				END IF;
			END IF;			
		END IF;


		IF(lower(_book) LIKE 'journal%') THEN
			IF(_can_verify_gl_transactions = false) THEN
				RAISE EXCEPTION 'Access is denied.';
			END IF;
			IF(_can_verify_gl_transactions = true) THEN
				IF(_posted_amount > _gl_verification_limit AND _gl_verification_limit > 0::money) THEN
					RAISE EXCEPTION 'GL verfication limit exceeded. The transaction was not verified.';
				END IF;
			END IF;			
		END IF;

		NEW.last_verified_on := now();

	END IF;	
	RETURN NEW;
END
$$
LANGUAGE plpgsql;


CREATE TRIGGER verification_update_trigger
AFTER UPDATE
ON transactions.transaction_master
FOR EACH ROW 
EXECUTE PROCEDURE transactions.verification_trigger();

CREATE TRIGGER verification_delete_trigger
BEFORE DELETE
ON transactions.transaction_master
FOR EACH ROW 
EXECUTE PROCEDURE transactions.verification_trigger();


DROP FUNCTION IF EXISTS transactions.auto_verify(bigint) CASCADE;

CREATE FUNCTION transactions.auto_verify(bigint)
RETURNS VOID
AS
$$
	DECLARE _transaction_master_id bigint;
	DECLARE _transaction_posted_by integer;
	DECLARE _verifier integer;
	DECLARE _status integer;
	DECLARE _reason national character varying(128);
	DECLARE _rejected smallint=-3;
	DECLARE _closed smallint=-2;
	DECLARE _withdrawn smallint=-1;
	DECLARE _unapproved smallint = 0;
	DECLARE _auto_approved smallint = 1;
	DECLARE _approved smallint=2;
	DECLARE _book text;
	DECLARE _auto_verify_sales boolean;
	DECLARE _sales_verification_limit money;
	DECLARE _auto_verify_purchase boolean;
	DECLARE _purchase_verification_limit money;
	DECLARE _auto_verify_gl boolean;
	DECLARE _gl_verification_limit money;
	DECLARE _posted_amount money;
	DECLARE _auto_verification boolean=true;
	DECLARE _has_policy boolean=false;
BEGIN
	_transaction_master_id := $1;

	SELECT
		transactions.transaction_master.book,
		transactions.transaction_master.user_id
	INTO
		_book,
		_transaction_posted_by 	
	FROM
	transactions.transaction_master
	WHERE transactions.transaction_master.transaction_master_id=_transaction_master_id;
	

	_verifier := office.get_sys_user_id();
	_status := 2;
	_reason := 'Automatically verified by workflow.';

	SELECT
		SUM(amount)
	INTO
		_posted_amount
	FROM
		transactions.transaction_details
	WHERE transactions.transaction_details.transaction_master_id = _transaction_master_id
	AND transactions.transaction_details.tran_type='Cr';


	SELECT
		true,
		verify_sales_transactions,
		sales_verification_limit,
		verify_purchase_transactions,
		purchase_verification_limit,
		verify_gl_transactions,
		gl_verification_limit
	INTO
		_has_policy,
		_auto_verify_sales,
		_sales_verification_limit,
		_auto_verify_purchase,
		_purchase_verification_limit,
		_auto_verify_gl,
		_gl_verification_limit
	FROM
	policy.auto_verification_policy
	WHERE user_id=_transaction_posted_by
	AND is_active=true
	AND now() >= effective_from
	AND now() <= ends_on;



	IF(lower(_book) LIKE 'sales%') THEN
		IF(_auto_verify_sales = false) THEN
			_auto_verification := false;
		END IF;
		IF(_auto_verify_sales = true) THEN
			IF(_posted_amount > _sales_verification_limit AND _sales_verification_limit > 0::money) THEN
				_auto_verification := false;
			END IF;
		END IF;			
	END IF;


	IF(lower(_book) LIKE 'purchase%') THEN
		IF(_auto_verify_purchase = false) THEN
			_auto_verification := false;
		END IF;
		IF(_auto_verify_purchase = true) THEN
			IF(_posted_amount > _purchase_verification_limit AND _purchase_verification_limit > 0::money) THEN
				_auto_verification := false;
			END IF;
		END IF;			
	END IF;


	IF(lower(_book) LIKE 'journal%') THEN
		IF(_auto_verify_gl = false) THEN
			_auto_verification := false;
		END IF;
		IF(_auto_verify_gl = true) THEN
			IF(_posted_amount > _gl_verification_limit AND _gl_verification_limit > 0::money) THEN
				_auto_verification := false;
			END IF;
		END IF;			
	END IF;

	IF(_has_policy=true) THEN
		IF(_auto_verification = true) THEN
			UPDATE transactions.transaction_master
			SET 
				last_verified_on = now(),
				verified_by_user_id=_verifier,
				verification_status_id=_status,
				verification_reason=_reason
			WHERE
				transactions.transaction_master.transaction_master_id=_transaction_master_id;
		END IF;
	ELSE
		RAISE NOTICE 'No auto verification policy found for this user.';
	END IF;
RETURN;
END
$$
LANGUAGE plpgsql;

DROP VIEW IF EXISTS transactions.verified_transactions_view;
DROP VIEW IF EXISTS transactions.transaction_view;
CREATE VIEW transactions.transaction_view
AS
SELECT
	transactions.transaction_master.transaction_master_id,
	transactions.transaction_master.transaction_counter,
	transactions.transaction_master.transaction_code,
	transactions.transaction_master.book,
	transactions.transaction_master.value_date,
	transactions.transaction_master.transaction_ts,
	transactions.transaction_master.login_id,
	transactions.transaction_master.user_id,
	transactions.transaction_master.sys_user_id,
	transactions.transaction_master.office_id,
	transactions.transaction_master.cost_center_id,
	transactions.transaction_master.reference_number,
	transactions.transaction_master.statement_reference AS master_statement_reference,
	transactions.transaction_master.last_verified_on,
	transactions.transaction_master.verified_by_user_id,
	transactions.transaction_master.verification_status_id,
	transactions.transaction_master.verification_reason,
	transactions.transaction_details.transaction_detail_id,
	transactions.transaction_details.tran_type,
	transactions.transaction_details.account_id,
	transactions.transaction_details.statement_reference,
	transactions.transaction_details.cash_repository_id,
	transactions.transaction_details.amount
FROM
transactions.transaction_master
INNER JOIN transactions.transaction_details
ON transactions.transaction_master.transaction_master_id = transactions.transaction_details.transaction_master_id;

CREATE VIEW transactions.verified_transactions_view
AS
SELECT * FROM transactions.transaction_view
WHERE verification_status_id > 0;


DROP FUNCTION IF EXISTS transactions.get_cash_repository_balance(integer);
CREATE FUNCTION transactions.get_cash_repository_balance(integer)
RETURNS money
AS
$$
	DECLARE _debit money;
	DECLARE _credit money;
BEGIN
	SELECT COALESCE(SUM(amount), 0::money) INTO _debit
	FROM transactions.verified_transactions_view
	WHERE cash_repository_id=$1
	AND tran_type='Dr';

	SELECT COALESCE(SUM(amount), 0::money) INTO _credit
	FROM transactions.verified_transactions_view
	WHERE cash_repository_id=$1
	AND tran_type='Cr';

	RETURN _debit - _credit;
END
$$
LANGUAGE plpgsql;


DROP FUNCTION IF EXISTS transactions.get_non_gl_product_view
(
	text,
	date, 
	date, 
	national character varying(12),
	text,	
	text,
	national character varying(50),
	national character varying(24),
	text
);

DROP FUNCTION IF EXISTS transactions.get_non_gl_product_view
(	
	user_id_				integer,
	book_					text,
	office_id_				integer,
	date_from_				date, 
	date_to_				date, 
	office_					national character varying(12),
	party_					text,	
	price_type_				text,
	user_					national character varying(50),
	reference_number_			national character varying(24),
	statement_reference_			text
 );

CREATE FUNCTION transactions.get_non_gl_product_view
(
	user_id_				integer,
	book_					text,
	office_id_				integer,
	date_from_				date, 
	date_to_				date, 
	office_					national character varying(12),
	party_					text,	
	price_type_				text,
	user_					national character varying(50),
	reference_number_			national character varying(24),
	statement_reference_			text
 )
RETURNS TABLE
(
	id					bigint,
	value_date				date,
	office					national character varying(12),
	party					text,
	price_type				text,
	amount					money_strict,
	transaction_ts				TIMESTAMP WITH TIME ZONE,
	"user"					national character varying(50),
	reference_number			national character varying(24),
	statement_reference			text,
	flag_background_color			text,
	flag_foreground_color			text
)
AS
$$
BEGIN
	RETURN QUERY 
	WITH RECURSIVE office_cte(office_id) AS 
	(
		SELECT office_id_
		UNION ALL
		SELECT
			c.office_id
		FROM 
		office_cte AS p, 
		office.offices AS c 
	    WHERE 
		parent_office_id = p.office_id
	)

	SELECT
		transactions.non_gl_stock_master.non_gl_stock_master_id AS id,
		transactions.non_gl_stock_master.value_date,
		office.offices.office_code AS office,
		core.parties.party_code || ' (' || core.parties.party_name || ')' AS party,
		core.price_types.price_type_code || ' (' || core.price_types.price_type_name || ')' AS price_type,
		SUM(transactions.non_gl_stock_details.price * transactions.non_gl_stock_details.quantity + tax - discount)::money_strict AS amount,
		transactions.non_gl_stock_master.transaction_ts,
		office.users.user_name AS user,
		transactions.non_gl_stock_master.reference_number,
		transactions.non_gl_stock_master.statement_reference,
		core.get_flag_background_color(core.get_flag_type_id(user_id_, 'transactions.non_gl_stock_master', 'non_gl_stock_master_id', transactions.non_gl_stock_master.non_gl_stock_master_id)) AS flag_bg,
		core.get_flag_foreground_color(core.get_flag_type_id(user_id_, 'transactions.non_gl_stock_master', 'non_gl_stock_master_id', transactions.non_gl_stock_master.non_gl_stock_master_id)) AS flag_fg
	FROM transactions.non_gl_stock_master
	INNER JOIN transactions.non_gl_stock_details
	ON transactions.non_gl_stock_master.non_gl_stock_master_id = transactions.non_gl_stock_details.non_gl_stock_master_id
	INNER JOIN core.parties
	ON transactions.non_gl_stock_master.party_id = core.parties.party_id
	INNER JOIN core.price_types
	ON transactions.non_gl_stock_master.price_type_id = core.price_types.price_type_id
	INNER JOIN office.users
	ON transactions.non_gl_stock_master.user_id = office.users.user_id
	INNER JOIN office.offices
	ON transactions.non_gl_stock_master.office_id = office.offices.office_id
	WHERE transactions.non_gl_stock_master.book = book_
	AND transactions.non_gl_stock_master.value_date BETWEEN date_from_ AND date_to_
	AND 
	lower
	(
		core.parties.party_code || ' (' || core.parties.party_name || ')'
	) LIKE '%' || lower(party_) || '%'
	AND
	lower
	(
		core.price_types.price_type_code || ' (' || core.price_types.price_type_name || ')'
	) LIKE '%' || lower(price_type_) || '%'
	AND 
	lower
	(
		office.users.user_name
	)  LIKE '%' || lower(user_) || '%'
	AND 
	lower
	(
		transactions.non_gl_stock_master.reference_number
	) LIKE '%' || lower(reference_number_) || '%'
	AND 
	lower
	(
		transactions.non_gl_stock_master.statement_reference
	) LIKE '%' || lower(statement_reference_) || '%'	
	AND lower
	(
		office.offices.office_code
	) LIKE '%' || lower(office_) || '%'	
	AND office.offices.office_id IN (SELECT office_id FROM office_cte)
	GROUP BY 
		transactions.non_gl_stock_master.non_gl_stock_master_id,
		transactions.non_gl_stock_master.value_date,
		office.offices.office_code,
		core.parties.party_code,
		core.parties.party_name,
		core.price_types.price_type_code,
		core.price_types.price_type_name,
		transactions.non_gl_stock_master.transaction_ts,
		office.users.user_name,
		transactions.non_gl_stock_master.reference_number,
		transactions.non_gl_stock_master.statement_reference		
	LIMIT 100;
END
$$
LANGUAGE plpgsql;

DROP FUNCTION IF EXISTS policy.check_menu_policy_trigger() CASCADE;


CREATE FUNCTION policy.check_menu_policy_trigger()
RETURNS trigger
AS
$$
	DECLARE count integer=0;
BEGIN
	IF NEW.office_id IS NOT NULL THEN
		count := count + 1;
	END IF;

	IF NEW.role_id IS NOT NULL THEN
		count := count + 1;
	END IF;
	
	IF NEW.user_id IS NOT NULL THEN
		count := count + 1;
	END IF;

	IF count <> 1 THEN
		RAISE EXCEPTION 'Only one of the following columns is required : office_id, role_id, user_id.';
	END IF;

	RETURN NEW;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER check_menu_policy_trigger BEFORE INSERT
ON policy.menu_policy
FOR EACH ROW EXECUTE PROCEDURE policy.check_menu_policy_trigger();

DROP FUNCTION IF EXISTS policy.get_menu(user_id_ integer, office_id_ integer, culture_ text);
CREATE FUNCTION policy.get_menu(user_id_ integer, office_id_ integer, culture_ text)
RETURNS TABLE
(
	menu_id			integer,
	menu_text		national character varying(250),
	url			national character varying(250),
	menu_code		character varying(12),
	level			smallint,
	parent_menu_id		integer
)
AS
$$
DECLARE culture_exists boolean = false;
BEGIN
	IF EXISTS(SELECT * FROM core.menu_locale WHERE culture=$3) THEN
		culture_exists := true;
	END IF;

	IF culture_exists THEN
		RETURN QUERY 
		SELECT
			core.menus.menu_id,
			core.menu_locale.menu_text,
			core.menus.url,
			core.menus.menu_code,
			core.menus.level,
			core.menus.parent_menu_id	
		FROM core.menus
		INNER JOIN policy.menu_access
		ON core.menus.menu_id = policy.menu_access.menu_id
		INNER JOIN core.menu_locale
		ON core.menus.menu_id = core.menu_locale.menu_id
		WHERE policy.menu_access.user_id=$1
		AND policy.menu_access.office_id=$2
		AND core.menu_locale.culture=$3;
	ELSE
		RETURN QUERY 
		SELECT
			core.menus.menu_id,
			core.menus.menu_text,
			core.menus.url,
			core.menus.menu_code,
			core.menus.level,
			core.menus.parent_menu_id	
		FROM core.menus
		INNER JOIN policy.menu_access
		ON core.menus.menu_id = policy.menu_access.menu_id
		WHERE policy.menu_access.user_id=$1
		AND policy.menu_access.office_id=$2;
	END IF;

END
$$
LANGUAGE plpgsql;


DROP FUNCTION IF EXISTS transactions.get_product_view
(
	text,
	date, 
	date, 
	national character varying(12),
	text,	
	text,
	national character varying(50),
	national character varying(24),
	text
);

DROP FUNCTION IF EXISTS transactions.get_product_view
(	
	user_id_				integer,
	book_					text,
	office_id_				integer,
	date_from_				date, 
	date_to_				date, 
	office_					national character varying(12),
	party_					text,	
	price_type_				text,
	user_					national character varying(50),
	reference_number_			national character varying(24),
	statement_reference_			text
 );

CREATE FUNCTION transactions.get_product_view
(
	user_id_				integer,
	book_					text,
	office_id_				integer,
	date_from_				date, 
	date_to_				date, 
	office_					national character varying(12),
	party_					text,	
	price_type_				text,
	user_					national character varying(50),
	reference_number_			national character varying(24),
	statement_reference_			text
 )
RETURNS TABLE
(
	id					bigint,
	value_date				date,
	office					national character varying(12),
	party					text,
	price_type				text,
	amount					money_strict,
	transaction_ts				TIMESTAMP WITH TIME ZONE,
	"user"					national character varying(50),
	reference_number			national character varying(24),
	statement_reference			text,
	agent					text,
	is_credit				boolean,
	shipper					text,
	shipping_address_code			text,
	store					text,	
	flag_background_color			text,
	flag_foreground_color			text
)
AS
$$
BEGIN
	RETURN QUERY 
	WITH RECURSIVE office_cte(office_id) AS 
	(
		SELECT office_id_
		UNION ALL
		SELECT
			c.office_id
		FROM 
		office_cte AS p, 
		office.offices AS c 
	    WHERE 
		parent_office_id = p.office_id
	)

	SELECT
		transactions.stock_master.stock_master_id AS id,
		transactions.transaction_master.value_date,
		office.offices.office_code AS office,
		core.parties.party_code || ' (' || core.parties.party_name || ')' AS party,
		core.price_types.price_type_code || ' (' || core.price_types.price_type_name || ')' AS price_type,
		SUM(transactions.stock_details.price * transactions.stock_details.quantity + tax - discount)::money_strict AS amount,
		transactions.transaction_master.transaction_ts,
		office.users.user_name AS user,
		transactions.transaction_master.reference_number,
		transactions.transaction_master.statement_reference,
		core.get_agent_name_by_agent_id(transactions.stock_master.agent_id),
		transactions.stock_master.is_credit,
		core.get_shipper_name_by_shipper_id(transactions.stock_master.shipper_id),
		core.get_shipping_address_code_by_shipping_address_id(transactions.stock_master.shipping_address_id),
		office.get_store_name_by_store_id(transactions.stock_master.store_id),
		core.get_flag_background_color(core.get_flag_type_id(user_id_, 'transactions.stock_master', 'stock_master_id', transactions.stock_master.stock_master_id)) AS flag_bg,
		core.get_flag_foreground_color(core.get_flag_type_id(user_id_, 'transactions.stock_master', 'stock_master_id', transactions.stock_master.stock_master_id)) AS flag_fg
	FROM transactions.stock_master
	INNER JOIN transactions.stock_details
	ON transactions.stock_master.stock_master_id = transactions.stock_details.stock_master_id
	INNER JOIN core.parties
	ON transactions.stock_master.party_id = core.parties.party_id
	INNER JOIN core.price_types
	ON transactions.stock_master.price_type_id = core.price_types.price_type_id
	INNER JOIN transactions.transaction_master
	ON transactions.transaction_master.transaction_master_id=transactions.stock_master.transaction_master_id
	INNER JOIN office.users
	ON transactions.transaction_master.user_id = office.users.user_id
	INNER JOIN office.offices
	ON transactions.transaction_master.office_id = office.offices.office_id
	WHERE transactions.transaction_master.book = book_
	AND transactions.transaction_master.verification_status_id > 0
	AND transactions.transaction_master.value_date BETWEEN date_from_ AND date_to_
	AND 
	lower
	(
		core.parties.party_code || ' (' || core.parties.party_name || ')'
	) LIKE '%' || lower(party_) || '%'
	AND
	lower
	(
		core.price_types.price_type_code || ' (' || core.price_types.price_type_name || ')'
	) LIKE '%' || lower(price_type_) || '%'
	AND 
	lower
	(
		office.users.user_name
	)  LIKE '%' || lower(user_) || '%'
	AND 
	lower
	(
		transactions.transaction_master.reference_number
	) LIKE '%' || lower(reference_number_) || '%'
	AND 
	lower
	(
		transactions.transaction_master.statement_reference
	) LIKE '%' || lower(statement_reference_) || '%'	
	AND lower
	(
		office.offices.office_code
	) LIKE '%' || lower(office_) || '%'	
	AND office.offices.office_id IN (SELECT office_id FROM office_cte)
	GROUP BY 
		transactions.stock_master.stock_master_id,
		transactions.transaction_master.value_date,
		office.offices.office_code,
		core.parties.party_code,
		core.parties.party_name,
		core.price_types.price_type_code,
		core.price_types.price_type_name,
		transactions.transaction_master.transaction_ts,
		office.users.user_name,
		transactions.transaction_master.reference_number,
		transactions.transaction_master.statement_reference		
	LIMIT 100;
END
$$
LANGUAGE plpgsql;


INSERT INTO policy.auto_verification_policy
SELECT 2, true, 0, true, 0, true, 0, NOW(), '1-1-2020', true;