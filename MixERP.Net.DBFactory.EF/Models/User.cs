using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class User
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public int OfficeId { get; set; }

    public string UserName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual ICollection<AccountParameter> AccountParameters { get; } = new List<AccountParameter>();

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<Agent> Agents { get; } = new List<Agent>();

    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<AutoVerificationPolicy> AutoVerificationPolicyAuditUsers { get; } = new List<AutoVerificationPolicy>();

    public virtual AutoVerificationPolicy? AutoVerificationPolicyUser { get; set; }

    public virtual ICollection<BankAccount> BankAccountAuditUsers { get; } = new List<BankAccount>();

    public virtual ICollection<BankAccount> BankAccountMaintainedByUsers { get; } = new List<BankAccount>();

    public virtual ICollection<BonusSlabDetail> BonusSlabDetails { get; } = new List<BonusSlabDetail>();

    public virtual ICollection<BonusSlab> BonusSlabs { get; } = new List<BonusSlab>();

    public virtual ICollection<CashRepository> CashRepositories { get; } = new List<CashRepository>();

    public virtual ICollection<Cashier> CashierAssignedByUsers { get; } = new List<Cashier>();

    public virtual ICollection<Cashier> CashierUsers { get; } = new List<Cashier>();

    public virtual ICollection<CompoundUnit> CompoundUnits { get; } = new List<CompoundUnit>();

    public virtual ICollection<CostCenter> CostCenters { get; } = new List<CostCenter>();

    public virtual ICollection<Counter> Counters { get; } = new List<Counter>();

    public virtual ICollection<Currency> Currencies { get; } = new List<Currency>();

    public virtual ICollection<Department> Departments { get; } = new List<Department>();

    public virtual ICollection<FailedLogin> FailedLogins { get; } = new List<FailedLogin>();

    public virtual ICollection<FiscalYear> FiscalYears { get; } = new List<FiscalYear>();

    public virtual ICollection<FlagType> FlagTypes { get; } = new List<FlagType>();

    public virtual ICollection<Flag> Flags { get; } = new List<Flag>();

    public virtual ICollection<FrequencySetup> FrequencySetups { get; } = new List<FrequencySetup>();

    public virtual ICollection<History> Histories { get; } = new List<History>();

    public virtual ICollection<User> InverseAuditUser { get; } = new List<User>();

    public virtual ICollection<ItemCostPrice> ItemCostPrices { get; } = new List<ItemCostPrice>();

    public virtual ICollection<ItemGroup> ItemGroups { get; } = new List<ItemGroup>();

    public virtual ICollection<ItemOpeningInventory> ItemOpeningInventories { get; } = new List<ItemOpeningInventory>();

    public virtual ICollection<ItemSellingPrice> ItemSellingPrices { get; } = new List<ItemSellingPrice>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<LeadSource> LeadSources { get; } = new List<LeadSource>();

    public virtual ICollection<LeadStatus> LeadStatuses { get; } = new List<LeadStatus>();

    public virtual ICollection<LockOut> LockOuts { get; } = new List<LockOut>();

    public virtual ICollection<Login> Logins { get; } = new List<Login>();

    public virtual ICollection<MenuAccess> MenuAccesses { get; } = new List<MenuAccess>();

    public virtual ICollection<MenuPolicy> MenuPolicies { get; } = new List<MenuPolicy>();

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();

    public virtual ICollection<NonGlStockDetail> NonGlStockDetails { get; } = new List<NonGlStockDetail>();

    public virtual ICollection<NonGlStockMaster> NonGlStockMasterAuditUsers { get; } = new List<NonGlStockMaster>();

    public virtual ICollection<NonGlStockMaster> NonGlStockMasterUsers { get; } = new List<NonGlStockMaster>();

    public virtual Office Office { get; set; } = null!;

    public virtual ICollection<Office> Offices { get; } = new List<Office>();

    public virtual ICollection<OpportunityStage> OpportunityStages { get; } = new List<OpportunityStage>();

    public virtual ICollection<Party> Parties { get; } = new List<Party>();

    public virtual ICollection<PartyType> PartyTypes { get; } = new List<PartyType>();

    public virtual ICollection<PriceType> PriceTypes { get; } = new List<PriceType>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; } = new List<Role>();

    public virtual ICollection<Shipper> Shippers { get; } = new List<Shipper>();

    public virtual ICollection<ShippingAddress> ShippingAddresses { get; } = new List<ShippingAddress>();

    public virtual ICollection<StockDetail> StockDetails { get; } = new List<StockDetail>();

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();

    public virtual ICollection<StorePolicy> StorePolicyAuditUsers { get; } = new List<StorePolicy>();

    public virtual ICollection<StorePolicyDetail> StorePolicyDetailAuditUsers { get; } = new List<StorePolicyDetail>();

    public virtual ICollection<StorePolicyDetail> StorePolicyDetailUsers { get; } = new List<StorePolicyDetail>();

    public virtual ICollection<StorePolicy> StorePolicyWrittenByUsers { get; } = new List<StorePolicy>();

    public virtual ICollection<StoreType> StoreTypes { get; } = new List<StoreType>();

    public virtual ICollection<Store> Stores { get; } = new List<Store>();

    public virtual ICollection<SwitchCategory> SwitchCategories { get; } = new List<SwitchCategory>();

    public virtual ICollection<TaxType> TaxTypes { get; } = new List<TaxType>();

    public virtual ICollection<Taxis> Taxes { get; } = new List<Taxis>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();

    public virtual ICollection<TransactionMaster> TransactionMasterAuditUsers { get; } = new List<TransactionMaster>();

    public virtual ICollection<TransactionMaster> TransactionMasterSysUsers { get; } = new List<TransactionMaster>();

    public virtual ICollection<TransactionMaster> TransactionMasterUsers { get; } = new List<TransactionMaster>();

    public virtual ICollection<TransactionMaster> TransactionMasterVerifiedByUsers { get; } = new List<TransactionMaster>();

    public virtual ICollection<Unit> Units { get; } = new List<Unit>();

    public virtual ICollection<VoucherVerificationPolicy> VoucherVerificationPolicyAuditUsers { get; } = new List<VoucherVerificationPolicy>();

    public virtual VoucherVerificationPolicy? VoucherVerificationPolicyUser { get; set; }

    public virtual ICollection<WorkCenter> WorkCenters { get; } = new List<WorkCenter>();
}
