using Microsoft.EntityFrameworkCore;
using MixERP.Net.DBFactory.EF.Models;

namespace MixERP.Net.DBFactory.EF.Context;

public partial class MixerpContext : DbContext
{
    public MixerpContext()
    {
    }

    public MixerpContext(DbContextOptions<MixerpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountMaster> AccountMasters { get; set; }

    public virtual DbSet<AccountParameter> AccountParameters { get; set; }

    public virtual DbSet<AccountView> AccountViews { get; set; }

    public virtual DbSet<AccountsView> AccountsViews { get; set; }

    public virtual DbSet<AgeingSlab> AgeingSlabs { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<AgentBonusSetup> AgentBonusSetups { get; set; }

    public virtual DbSet<AgentBonusSetupView> AgentBonusSetupViews { get; set; }

    public virtual DbSet<AgentView> AgentViews { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<AutoVerificationPolicy> AutoVerificationPolicies { get; set; }

    public virtual DbSet<AutoVerificationPolicyView> AutoVerificationPolicyViews { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<BankAccountView> BankAccountViews { get; set; }

    public virtual DbSet<BonusSlab> BonusSlabs { get; set; }

    public virtual DbSet<BonusSlabDetail> BonusSlabDetails { get; set; }

    public virtual DbSet<BonusSlabDetailView> BonusSlabDetailViews { get; set; }

    public virtual DbSet<BonusSlabView> BonusSlabViews { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CashRepository> CashRepositories { get; set; }

    public virtual DbSet<Cashier> Cashiers { get; set; }

    public virtual DbSet<CompoundUnit> CompoundUnits { get; set; }

    public virtual DbSet<CompoundUnitView> CompoundUnitViews { get; set; }

    public virtual DbSet<CostCenter> CostCenters { get; set; }

    public virtual DbSet<CostCenterView> CostCenterViews { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<DbStat> DbStats { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<FailedLogin> FailedLogins { get; set; }

    public virtual DbSet<FiscalYear> FiscalYears { get; set; }

    public virtual DbSet<Flag> Flags { get; set; }

    public virtual DbSet<FlagType> FlagTypes { get; set; }

    public virtual DbSet<Frequency> Frequencies { get; set; }

    public virtual DbSet<FrequencySetup> FrequencySetups { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemCostPrice> ItemCostPrices { get; set; }

    public virtual DbSet<ItemGroup> ItemGroups { get; set; }

    public virtual DbSet<ItemOpeningInventory> ItemOpeningInventories { get; set; }

    public virtual DbSet<ItemSellingPrice> ItemSellingPrices { get; set; }

    public virtual DbSet<LeadSource> LeadSources { get; set; }

    public virtual DbSet<LeadStatus> LeadStatuses { get; set; }

    public virtual DbSet<LockOut> LockOuts { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuAccess> MenuAccesses { get; set; }

    public virtual DbSet<MenuLocale> MenuLocales { get; set; }

    public virtual DbSet<MenuPolicy> MenuPolicies { get; set; }

    public virtual DbSet<NonGlStockDetail> NonGlStockDetails { get; set; }

    public virtual DbSet<NonGlStockMaster> NonGlStockMasters { get; set; }

    public virtual DbSet<NonGlStockMasterRelation> NonGlStockMasterRelations { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<OfficeView> OfficeViews { get; set; }

    public virtual DbSet<OpportunityStage> OpportunityStages { get; set; }

    public virtual DbSet<Party> Parties { get; set; }

    public virtual DbSet<PartyType> PartyTypes { get; set; }

    public virtual DbSet<PriceType> PriceTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleView> RoleViews { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<ShippingAddress> ShippingAddresses { get; set; }

    public virtual DbSet<StockDetail> StockDetails { get; set; }

    public virtual DbSet<StockMaster> StockMasters { get; set; }

    public virtual DbSet<StockMasterNonGlRelation> StockMasterNonGlRelations { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StorePolicy> StorePolicies { get; set; }

    public virtual DbSet<StorePolicyDetail> StorePolicyDetails { get; set; }

    public virtual DbSet<StoreType> StoreTypes { get; set; }

    public virtual DbSet<StoreView> StoreViews { get; set; }

    public virtual DbSet<SwitchCategory> SwitchCategories { get; set; }

    public virtual DbSet<TaxType> TaxTypes { get; set; }

    public virtual DbSet<Taxis> Taxes { get; set; }

    public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }

    public virtual DbSet<TransactionMaster> TransactionMasters { get; set; }

    public virtual DbSet<TrialBalanceView> TrialBalanceViews { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnitView> UnitViews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VerificationStatus> VerificationStatuses { get; set; }

    public virtual DbSet<VoucherVerificationPolicy> VoucherVerificationPolicies { get; set; }

    public virtual DbSet<VoucherVerificationPolicyView> VoucherVerificationPolicyViews { get; set; }

    public virtual DbSet<WorkCenter> WorkCenters { get; set; }

    public virtual DbSet<WorkCenterView> WorkCenterViews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=mixerp;Username=mix_erp;Password=Qwerty");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("accounts_pkey");

            entity.ToTable("accounts", "core");

            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(12)
                .HasColumnName("account_code");
            entity.Property(e => e.AccountMasterId).HasColumnName("account_master_id");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("account_name");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Confidential).HasColumnName("confidential");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(12)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("external_code");
            entity.Property(e => e.IsCash).HasColumnName("is_cash");
            entity.Property(e => e.ParentAccountId).HasColumnName("parent_account_id");
            entity.Property(e => e.SysType).HasColumnName("sys_type");

            entity.HasOne(d => d.AccountMaster).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AccountMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounts_account_master_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("accounts_audit_user_id_fkey");

            entity.HasOne(d => d.ParentAccount).WithMany(p => p.InverseParentAccount)
                .HasForeignKey(d => d.ParentAccountId)
                .HasConstraintName("accounts_parent_account_id_fkey");
        });

        modelBuilder.Entity<AccountMaster>(entity =>
        {
            entity.HasKey(e => e.AccountMasterId).HasName("account_masters_pkey");

            entity.ToTable("account_masters", "core");

            entity.Property(e => e.AccountMasterId).HasColumnName("account_master_id");
            entity.Property(e => e.AccountMasterCode)
                .HasMaxLength(3)
                .HasColumnName("account_master_code");
            entity.Property(e => e.AccountMasterName)
                .HasMaxLength(40)
                .HasColumnName("account_master_name");
        });

        modelBuilder.Entity<AccountParameter>(entity =>
        {
            entity.HasKey(e => e.AccountParameterId).HasName("account_parameters_pk");

            entity.ToTable("account_parameters", "core");

            entity.Property(e => e.AccountParameterId).HasColumnName("account_parameter_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.ParameterName)
                .HasMaxLength(128)
                .HasColumnName("parameter_name");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountParameters)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("account_parameters_account_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.AccountParameters)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("account_parameters_audit_user_id_fkey");
        });

        modelBuilder.Entity<AccountView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("account_view", "core");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(12)
                .HasColumnName("account_code");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountMasterCode)
                .HasMaxLength(3)
                .HasColumnName("account_master_code");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("account_name");
            entity.Property(e => e.Confidential).HasColumnName("confidential");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(12)
                .HasColumnName("external_code");
            entity.Property(e => e.HasChild).HasColumnName("has_child");
            entity.Property(e => e.IsCash).HasColumnName("is_cash");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.SysType).HasColumnName("sys_type");
        });

        modelBuilder.Entity<AccountsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("accounts_view", "core");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(12)
                .HasColumnName("account_code");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountMasterCode)
                .HasMaxLength(3)
                .HasColumnName("account_master_code");
            entity.Property(e => e.AccountMasterId).HasColumnName("account_master_id");
            entity.Property(e => e.AccountMasterName)
                .HasMaxLength(40)
                .HasColumnName("account_master_name");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("account_name");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.ParentAccountCode)
                .HasMaxLength(12)
                .HasColumnName("parent_account_code");
            entity.Property(e => e.ParentAccountId).HasColumnName("parent_account_id");
            entity.Property(e => e.ParentAccountName)
                .HasMaxLength(100)
                .HasColumnName("parent_account_name");
            entity.Property(e => e.SysType).HasColumnName("sys_type");
        });

        modelBuilder.Entity<AgeingSlab>(entity =>
        {
            entity.HasKey(e => e.AgeingSlabId).HasName("ageing_slabs_pkey");

            entity.ToTable("ageing_slabs", "core");

            entity.Property(e => e.AgeingSlabId).HasColumnName("ageing_slab_id");
            entity.Property(e => e.AgeingSlabName)
                .HasMaxLength(24)
                .HasColumnName("ageing_slab_name");
            entity.Property(e => e.FromDays).HasColumnName("from_days");
            entity.Property(e => e.ToDays).HasColumnName("to_days");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasName("agents_pkey");

            entity.ToTable("agents", "core");

            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.AgentCode)
                .HasMaxLength(12)
                .HasColumnName("agent_code");
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .HasColumnName("agent_name");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CommissionRate).HasColumnName("commission_rate");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .HasColumnName("contact_number");

            entity.HasOne(d => d.Account).WithMany(p => p.Agents)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("agents_account_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Agents)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("agents_audit_user_id_fkey");
        });

        modelBuilder.Entity<AgentBonusSetup>(entity =>
        {
            entity.HasKey(e => e.AgentBonusSetupId).HasName("agent_bonus_setups_pkey");

            entity.ToTable("agent_bonus_setups", "core");

            entity.HasIndex(e => new { e.AgentId, e.BonusSlabId }, "agent_bonus_setups_uix").IsUnique();

            entity.Property(e => e.AgentBonusSetupId).HasColumnName("agent_bonus_setup_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BonusSlabId).HasColumnName("bonus_slab_id");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentBonusSetups)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("agent_bonus_setups_agent_id_fkey");

            entity.HasOne(d => d.BonusSlab).WithMany(p => p.AgentBonusSetups)
                .HasForeignKey(d => d.BonusSlabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("agent_bonus_setups_bonus_slab_id_fkey");
        });

        modelBuilder.Entity<AgentBonusSetupView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("agent_bonus_setup_view", "core");

            entity.Property(e => e.AgentBonusSetupId).HasColumnName("agent_bonus_setup_id");
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .HasColumnName("agent_name");
            entity.Property(e => e.BonusSlabName)
                .HasMaxLength(50)
                .HasColumnName("bonus_slab_name");
        });

        modelBuilder.Entity<AgentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("agent_view", "core");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("account_name");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.AgentCode)
                .HasMaxLength(12)
                .HasColumnName("agent_code");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .HasColumnName("agent_name");
            entity.Property(e => e.CommissionRate).HasColumnName("commission_rate");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .HasColumnName("contact_number");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("attachments_pkey");

            entity.ToTable("attachments", "transactions");

            entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("added_on");
            entity.Property(e => e.Comment)
                .HasMaxLength(96)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("comment");
            entity.Property(e => e.FileExtension)
                .HasMaxLength(12)
                .HasColumnName("file_extension");
            entity.Property(e => e.FilePath).HasColumnName("file_path");
            entity.Property(e => e.OriginalFileName).HasColumnName("original_file_name");
            entity.Property(e => e.Resource).HasColumnName("resource");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ResourceKey).HasColumnName("resource_key");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attachments_users_fk");
        });

        modelBuilder.Entity<AutoVerificationPolicy>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("auto_verification_policy_pkey");

            entity.ToTable("auto_verification_policy", "policy");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.EffectiveFrom).HasColumnName("effective_from");
            entity.Property(e => e.EndsOn).HasColumnName("ends_on");
            entity.Property(e => e.GlVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("gl_verification_limit");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.PurchaseVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("purchase_verification_limit");
            entity.Property(e => e.SalesVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("sales_verification_limit");
            entity.Property(e => e.VerifyGlTransactions).HasColumnName("verify_gl_transactions");
            entity.Property(e => e.VerifyPurchaseTransactions).HasColumnName("verify_purchase_transactions");
            entity.Property(e => e.VerifySalesTransactions).HasColumnName("verify_sales_transactions");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.AutoVerificationPolicyAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("auto_verification_policy_audit_user_id_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.AutoVerificationPolicyUser)
                .HasForeignKey<AutoVerificationPolicy>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auto_verification_policy_user_id_fkey");
        });

        modelBuilder.Entity<AutoVerificationPolicyView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("auto_verification_policy_view", "policy");

            entity.Property(e => e.EffectiveFrom).HasColumnName("effective_from");
            entity.Property(e => e.EndsOn).HasColumnName("ends_on");
            entity.Property(e => e.GlVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("gl_verification_limit");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.PurchaseVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("purchase_verification_limit");
            entity.Property(e => e.SalesVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("sales_verification_limit");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
            entity.Property(e => e.VerifyGlTransactions).HasColumnName("verify_gl_transactions");
            entity.Property(e => e.VerifyPurchaseTransactions).HasColumnName("verify_purchase_transactions");
            entity.Property(e => e.VerifySalesTransactions).HasColumnName("verify_sales_transactions");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("bank_accounts_pk");

            entity.ToTable("bank_accounts", "core");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("account_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BankAccountCode)
                .HasMaxLength(128)
                .HasColumnName("bank_account_code");
            entity.Property(e => e.BankAccountType)
                .HasMaxLength(128)
                .HasColumnName("bank_account_type");
            entity.Property(e => e.BankAddress).HasColumnName("bank_address");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(128)
                .HasColumnName("bank_branch");
            entity.Property(e => e.BankContactNumber)
                .HasMaxLength(128)
                .HasColumnName("bank_contact_number");
            entity.Property(e => e.BankName)
                .HasMaxLength(128)
                .HasColumnName("bank_name");
            entity.Property(e => e.MaintainedByUserId).HasColumnName("maintained_by_user_id");
            entity.Property(e => e.RelationshipOfficerName)
                .HasMaxLength(128)
                .HasColumnName("relationship_officer_name");

            entity.HasOne(d => d.Account).WithOne(p => p.BankAccount)
                .HasForeignKey<BankAccount>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("bank_accounts_accounts_fk");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.BankAccountAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("bank_accounts_audit_user_id_fkey");

            entity.HasOne(d => d.MaintainedByUser).WithMany(p => p.BankAccountMaintainedByUsers)
                .HasForeignKey(d => d.MaintainedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("bank_accounts_users_fk");
        });

        modelBuilder.Entity<BankAccountView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bank_account_view", "core");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(12)
                .HasColumnName("account_code");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("account_name");
            entity.Property(e => e.BankAccountCode)
                .HasMaxLength(128)
                .HasColumnName("bank_account_code");
            entity.Property(e => e.BankAccountType)
                .HasMaxLength(128)
                .HasColumnName("bank_account_type");
            entity.Property(e => e.BankAddress).HasColumnName("bank_address");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(128)
                .HasColumnName("bank_branch");
            entity.Property(e => e.BankContactNumber)
                .HasMaxLength(128)
                .HasColumnName("bank_contact_number");
            entity.Property(e => e.BankName)
                .HasMaxLength(128)
                .HasColumnName("bank_name");
            entity.Property(e => e.MaintainedBy)
                .HasMaxLength(50)
                .HasColumnName("maintained_by");
            entity.Property(e => e.RelationOfficer)
                .HasMaxLength(128)
                .HasColumnName("relation_officer");
        });

        modelBuilder.Entity<BonusSlab>(entity =>
        {
            entity.HasKey(e => e.BonusSlabId).HasName("bonus_slabs_pkey");

            entity.ToTable("bonus_slabs", "core");

            entity.Property(e => e.BonusSlabId).HasColumnName("bonus_slab_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BonusSlabCode)
                .HasMaxLength(12)
                .HasColumnName("bonus_slab_code");
            entity.Property(e => e.BonusSlabName)
                .HasMaxLength(50)
                .HasColumnName("bonus_slab_name");
            entity.Property(e => e.CheckingFrequencyId).HasColumnName("checking_frequency_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.BonusSlabs)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("bonus_slabs_audit_user_id_fkey");

            entity.HasOne(d => d.CheckingFrequency).WithMany(p => p.BonusSlabs)
                .HasForeignKey(d => d.CheckingFrequencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("bonus_slabs_checking_frequency_id_fkey");
        });

        modelBuilder.Entity<BonusSlabDetail>(entity =>
        {
            entity.HasKey(e => e.BonusSlabDetailId).HasName("bonus_slab_details_pkey");

            entity.ToTable("bonus_slab_details", "core");

            entity.Property(e => e.BonusSlabDetailId).HasColumnName("bonus_slab_detail_id");
            entity.Property(e => e.AmountFrom)
                .HasColumnType("money")
                .HasColumnName("amount_from");
            entity.Property(e => e.AmountTo)
                .HasColumnType("money")
                .HasColumnName("amount_to");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BonusRate).HasColumnName("bonus_rate");
            entity.Property(e => e.BonusSlabId).HasColumnName("bonus_slab_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.BonusSlabDetails)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("bonus_slab_details_audit_user_id_fkey");

            entity.HasOne(d => d.BonusSlab).WithMany(p => p.BonusSlabDetails)
                .HasForeignKey(d => d.BonusSlabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("bonus_slab_details_bonus_slab_id_fkey");
        });

        modelBuilder.Entity<BonusSlabDetailView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bonus_slab_detail_view", "core");

            entity.Property(e => e.AmountFrom)
                .HasColumnType("money")
                .HasColumnName("amount_from");
            entity.Property(e => e.AmountTo)
                .HasColumnType("money")
                .HasColumnName("amount_to");
            entity.Property(e => e.BonusRate).HasColumnName("bonus_rate");
            entity.Property(e => e.BonusSlabDetailId).HasColumnName("bonus_slab_detail_id");
            entity.Property(e => e.BonusSlabId).HasColumnName("bonus_slab_id");
            entity.Property(e => e.SlabName)
                .HasMaxLength(50)
                .HasColumnName("slab_name");
        });

        modelBuilder.Entity<BonusSlabView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bonus_slab_view", "core");

            entity.Property(e => e.BonusSlabCode)
                .HasMaxLength(12)
                .HasColumnName("bonus_slab_code");
            entity.Property(e => e.BonusSlabId).HasColumnName("bonus_slab_id");
            entity.Property(e => e.BonusSlabName)
                .HasMaxLength(50)
                .HasColumnName("bonus_slab_name");
            entity.Property(e => e.CheckingFrequencyId).HasColumnName("checking_frequency_id");
            entity.Property(e => e.FrequencyName)
                .HasMaxLength(50)
                .HasColumnName("frequency_name");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("brands_pkey");

            entity.ToTable("brands", "core");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandCode)
                .HasMaxLength(12)
                .HasColumnName("brand_code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(150)
                .HasColumnName("brand_name");
        });

        modelBuilder.Entity<CashRepository>(entity =>
        {
            entity.HasKey(e => e.CashRepositoryId).HasName("cash_repositories_pkey");

            entity.ToTable("cash_repositories", "office");

            entity.Property(e => e.CashRepositoryId).HasColumnName("cash_repository_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CashRepositoryCode)
                .HasMaxLength(12)
                .HasColumnName("cash_repository_code");
            entity.Property(e => e.CashRepositoryName)
                .HasMaxLength(50)
                .HasColumnName("cash_repository_name");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.ParentCashRepositoryId).HasColumnName("parent_cash_repository_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.CashRepositories)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("cash_repositories_audit_user_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.CashRepositories)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cash_repositories_office_id_fkey");

            entity.HasOne(d => d.ParentCashRepository).WithMany(p => p.InverseParentCashRepository)
                .HasForeignKey(d => d.ParentCashRepositoryId)
                .HasConstraintName("cash_repositories_parent_cash_repository_id_fkey");
        });

        modelBuilder.Entity<Cashier>(entity =>
        {
            entity.HasKey(e => e.CashierId).HasName("cashiers_pkey");

            entity.ToTable("cashiers", "office");

            entity.HasIndex(e => new { e.UserId, e.TransactionDate }, "cashiers_user_id_tdate_uix")
                .IsUnique()
                .IsDescending(false, true);

            entity.Property(e => e.CashierId).HasColumnName("cashier_id");
            entity.Property(e => e.AssignedByUserId).HasColumnName("assigned_by_user_id");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.CounterId).HasColumnName("counter_id");
            entity.Property(e => e.TransactionDate).HasColumnName("transaction_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AssignedByUser).WithMany(p => p.CashierAssignedByUsers)
                .HasForeignKey(d => d.AssignedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cashiers_assigned_by_user_id_fkey");

            entity.HasOne(d => d.Counter).WithMany(p => p.Cashiers)
                .HasForeignKey(d => d.CounterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cashiers_counter_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CashierUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cashiers_user_id_fkey");
        });

        modelBuilder.Entity<CompoundUnit>(entity =>
        {
            entity.HasKey(e => e.CompoundUnitId).HasName("compound_units_pkey");

            entity.ToTable("compound_units", "core");

            entity.HasIndex(e => new { e.BaseUnitId, e.CompareUnitId }, "compound_units_info_uix").IsUnique();

            entity.Property(e => e.CompoundUnitId).HasColumnName("compound_unit_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BaseUnitId).HasColumnName("base_unit_id");
            entity.Property(e => e.CompareUnitId).HasColumnName("compare_unit_id");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.CompoundUnits)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("compound_units_audit_user_id_fkey");

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.CompoundUnitBaseUnits)
                .HasForeignKey(d => d.BaseUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("compound_units_base_unit_id_fkey");

            entity.HasOne(d => d.CompareUnit).WithMany(p => p.CompoundUnitCompareUnits)
                .HasForeignKey(d => d.CompareUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("compound_units_compare_unit_id_fkey");
        });

        modelBuilder.Entity<CompoundUnitView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("compound_unit_view", "core");

            entity.Property(e => e.BaseUnitName)
                .HasMaxLength(50)
                .HasColumnName("base_unit_name");
            entity.Property(e => e.CompareUnitName)
                .HasMaxLength(50)
                .HasColumnName("compare_unit_name");
            entity.Property(e => e.CompoundUnitId).HasColumnName("compound_unit_id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CostCenter>(entity =>
        {
            entity.HasKey(e => e.CostCenterId).HasName("cost_centers_pkey");

            entity.ToTable("cost_centers", "office");

            entity.Property(e => e.CostCenterId).HasColumnName("cost_center_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CostCenterCode)
                .HasMaxLength(24)
                .HasColumnName("cost_center_code");
            entity.Property(e => e.CostCenterName)
                .HasMaxLength(50)
                .HasColumnName("cost_center_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("cost_centers_audit_user_id_fkey");
        });

        modelBuilder.Entity<CostCenterView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cost_center_view", "office");

            entity.Property(e => e.CostCenterCode)
                .HasMaxLength(24)
                .HasColumnName("cost_center_code");
            entity.Property(e => e.CostCenterId).HasColumnName("cost_center_id");
            entity.Property(e => e.CostCenterName)
                .HasMaxLength(50)
                .HasColumnName("cost_center_name");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => e.CounterId).HasName("counters_pkey");

            entity.ToTable("counters", "office");

            entity.Property(e => e.CounterId).HasColumnName("counter_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CashRepositoryId).HasColumnName("cash_repository_id");
            entity.Property(e => e.CounterCode)
                .HasMaxLength(12)
                .HasColumnName("counter_code");
            entity.Property(e => e.CounterName)
                .HasMaxLength(50)
                .HasColumnName("counter_name");
            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Counters)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("counters_audit_user_id_fkey");

            entity.HasOne(d => d.CashRepository).WithMany(p => p.Counters)
                .HasForeignKey(d => d.CashRepositoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("counters_cash_repository_id_fkey");

            entity.HasOne(d => d.Store).WithMany(p => p.Counters)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("counters_store_id_fkey");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyCode).HasName("currencies_pkey");

            entity.ToTable("currencies", "core");

            entity.HasIndex(e => e.CurrencyName, "currencies_currency_name_key").IsUnique();

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(12)
                .HasColumnName("currency_code");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(48)
                .HasColumnName("currency_name");
            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(12)
                .HasColumnName("currency_symbol");
            entity.Property(e => e.HundredthName)
                .HasMaxLength(48)
                .HasColumnName("hundredth_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Currencies)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("currencies_audit_user_id_fkey");
        });

        modelBuilder.Entity<DbStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("db_stat");

            entity.Property(e => e.AnalyzeCount).HasColumnName("analyze_count");
            entity.Property(e => e.AutoanalyzeCount).HasColumnName("autoanalyze_count");
            entity.Property(e => e.AutovacuumCount).HasColumnName("autovacuum_count");
            entity.Property(e => e.LastAnalyze).HasColumnName("last_analyze");
            entity.Property(e => e.LastAutoanalyze).HasColumnName("last_autoanalyze");
            entity.Property(e => e.LastAutovacuum).HasColumnName("last_autovacuum");
            entity.Property(e => e.LastVacuum).HasColumnName("last_vacuum");
            entity.Property(e => e.VacuumCount).HasColumnName("vacuum_count");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("departments_pkey");

            entity.ToTable("departments", "office");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(12)
                .HasColumnName("department_code");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Departments)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("departments_audit_user_id_fkey");
        });

        modelBuilder.Entity<FailedLogin>(entity =>
        {
            entity.HasKey(e => e.FailedLoginId).HasName("failed_logins_pkey");

            entity.ToTable("failed_logins", "audit");

            entity.Property(e => e.FailedLoginId).HasColumnName("failed_login_id");
            entity.Property(e => e.Browser)
                .HasMaxLength(500)
                .HasColumnName("browser");
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .HasColumnName("details");
            entity.Property(e => e.FailedDateTime)
                .HasDefaultValueSql("now()")
                .HasColumnName("failed_date_time");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("ip_address");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.RemoteUser)
                .HasMaxLength(50)
                .HasColumnName("remote_user");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");

            entity.HasOne(d => d.Office).WithMany(p => p.FailedLogins)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("failed_logins_office_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.FailedLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("failed_logins_user_id_fkey");
        });

        modelBuilder.Entity<FiscalYear>(entity =>
        {
            entity.HasKey(e => e.FiscalYearCode).HasName("fiscal_year_pkey");

            entity.ToTable("fiscal_year", "core");

            entity.HasIndex(e => e.EndsOn, "fiscal_year_ends_on_uix").IsUnique();

            entity.HasIndex(e => e.StartsFrom, "fiscal_year_starts_from_uix").IsUnique();

            entity.Property(e => e.FiscalYearCode)
                .HasMaxLength(12)
                .HasColumnName("fiscal_year_code");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.EndsOn).HasColumnName("ends_on");
            entity.Property(e => e.FiscalYearName)
                .HasMaxLength(50)
                .HasColumnName("fiscal_year_name");
            entity.Property(e => e.StartsFrom).HasColumnName("starts_from");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.FiscalYears)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("fiscal_year_audit_user_id_fkey");
        });

        modelBuilder.Entity<Flag>(entity =>
        {
            entity.HasKey(e => e.FlagId).HasName("flags_pkey");

            entity.ToTable("flags", "core");

            entity.Property(e => e.FlagId).HasColumnName("flag_id");
            entity.Property(e => e.FlagTypeId).HasColumnName("flag_type_id");
            entity.Property(e => e.FlaggedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("flagged_on");
            entity.Property(e => e.Resource).HasColumnName("resource");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ResourceKey).HasColumnName("resource_key");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.FlagType).WithMany(p => p.Flags)
                .HasForeignKey(d => d.FlagTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("flags_flag_type_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Flags)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("flags_user_id_fkey");
        });

        modelBuilder.Entity<FlagType>(entity =>
        {
            entity.HasKey(e => e.FlagTypeId).HasName("flag_types_pkey");

            entity.ToTable("flag_types", "core");

            entity.Property(e => e.FlagTypeId).HasColumnName("flag_type_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BackgroundColor).HasColumnName("background_color");
            entity.Property(e => e.FlagTypeName)
                .HasMaxLength(24)
                .HasColumnName("flag_type_name");
            entity.Property(e => e.ForegroundColor).HasColumnName("foreground_color");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.FlagTypes)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("flag_types_audit_user_id_fkey");
        });

        modelBuilder.Entity<Frequency>(entity =>
        {
            entity.HasKey(e => e.FrequencyId).HasName("frequencies_pkey");

            entity.ToTable("frequencies", "core");

            entity.Property(e => e.FrequencyId).HasColumnName("frequency_id");
            entity.Property(e => e.FrequencyCode)
                .HasMaxLength(12)
                .HasColumnName("frequency_code");
            entity.Property(e => e.FrequencyName)
                .HasMaxLength(50)
                .HasColumnName("frequency_name");
        });

        modelBuilder.Entity<FrequencySetup>(entity =>
        {
            entity.HasKey(e => e.FrequencySetupId).HasName("frequency_setups_pkey");

            entity.ToTable("frequency_setups", "core");

            entity.HasIndex(e => e.ValueDate, "frequency_setups_value_date_key").IsUnique();

            entity.Property(e => e.FrequencySetupId).HasColumnName("frequency_setup_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.FiscalYearCode)
                .HasMaxLength(12)
                .HasColumnName("fiscal_year_code");
            entity.Property(e => e.FrequencyId).HasColumnName("frequency_id");
            entity.Property(e => e.ValueDate).HasColumnName("value_date");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.FrequencySetups)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("frequency_setups_audit_user_id_fkey");

            entity.HasOne(d => d.FiscalYearCodeNavigation).WithMany(p => p.FrequencySetups)
                .HasForeignKey(d => d.FiscalYearCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frequency_setups_fiscal_year_code_fkey");

            entity.HasOne(d => d.Frequency).WithMany(p => p.FrequencySetups)
                .HasForeignKey(d => d.FrequencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frequency_setups_frequency_id_fkey");
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("history_pkey");

            entity.ToTable("history", "audit");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .HasColumnName("column_name");
            entity.Property(e => e.EventTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("event_ts");
            entity.Property(e => e.NewVal).HasColumnName("new_val");
            entity.Property(e => e.OldVal).HasColumnName("old_val");
            entity.Property(e => e.PrimaryKeyId)
                .HasMaxLength(50)
                .HasColumnName("primary_key_id");
            entity.Property(e => e.PrincipalUser)
                .HasMaxLength(50)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("principal_user");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(50)
                .HasColumnName("table_schema");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Histories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("history_user_id_fkey");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("items_pkey");

            entity.ToTable("items", "core");

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CostPrice)
                .HasColumnType("money")
                .HasColumnName("cost_price");
            entity.Property(e => e.CostPriceIncludesTax).HasColumnName("cost_price_includes_tax");
            entity.Property(e => e.HotItem).HasColumnName("hot_item");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(12)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemGroupId).HasColumnName("item_group_id");
            entity.Property(e => e.ItemImage).HasColumnName("item_image");
            entity.Property(e => e.ItemName)
                .HasMaxLength(150)
                .HasColumnName("item_name");
            entity.Property(e => e.LeadTimeInDays).HasColumnName("lead_time_in_days");
            entity.Property(e => e.MaintainStock)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("maintain_stock");
            entity.Property(e => e.PreferredSupplierId).HasColumnName("preferred_supplier_id");
            entity.Property(e => e.ReorderLevel).HasColumnName("reorder_level");
            entity.Property(e => e.SellingPrice)
                .HasColumnType("money")
                .HasColumnName("selling_price");
            entity.Property(e => e.SellingPriceIncludesTax).HasColumnName("selling_price_includes_tax");
            entity.Property(e => e.TaxId).HasColumnName("tax_id");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Items)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("items_audit_user_id_fkey");

            entity.HasOne(d => d.Brand).WithMany(p => p.Items)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("items_brand_id_fkey");

            entity.HasOne(d => d.ItemGroup).WithMany(p => p.Items)
                .HasForeignKey(d => d.ItemGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("items_item_group_id_fkey");

            entity.HasOne(d => d.PreferredSupplier).WithMany(p => p.Items)
                .HasForeignKey(d => d.PreferredSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("items_preferred_supplier_id_fkey");

            entity.HasOne(d => d.Tax).WithMany(p => p.Items)
                .HasForeignKey(d => d.TaxId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("items_tax_id_fkey");

            entity.HasOne(d => d.Unit).WithMany(p => p.Items)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("items_unit_id_fkey");
        });

        modelBuilder.Entity<ItemCostPrice>(entity =>
        {
            entity.HasKey(e => e.ItemCostPriceId).HasName("item_cost_prices_pkey");

            entity.ToTable("item_cost_prices", "core");

            entity.Property(e => e.ItemCostPriceId).HasColumnName("item_cost_price_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.EntryTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("entry_ts");
            entity.Property(e => e.IncludesTax).HasColumnName("includes_tax");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LeadTimeInDays).HasColumnName("lead_time_in_days");
            entity.Property(e => e.PartyId).HasColumnName("party_id");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.ItemCostPrices)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("item_cost_prices_audit_user_id_fkey");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemCostPrices)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_cost_prices_item_id_fkey");

            entity.HasOne(d => d.Party).WithMany(p => p.ItemCostPrices)
                .HasForeignKey(d => d.PartyId)
                .HasConstraintName("item_cost_prices_party_id_fkey");

            entity.HasOne(d => d.Unit).WithMany(p => p.ItemCostPrices)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_cost_prices_unit_id_fkey");
        });

        modelBuilder.Entity<ItemGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupId).HasName("item_groups_pkey");

            entity.ToTable("item_groups", "core");

            entity.Property(e => e.ItemGroupId).HasColumnName("item_group_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.ExcludeFromPurchase).HasColumnName("exclude_from_purchase");
            entity.Property(e => e.ExcludeFromSales).HasColumnName("exclude_from_sales");
            entity.Property(e => e.ItemGroupCode)
                .HasMaxLength(12)
                .HasColumnName("item_group_code");
            entity.Property(e => e.ItemGroupName)
                .HasMaxLength(50)
                .HasColumnName("item_group_name");
            entity.Property(e => e.TaxId).HasColumnName("tax_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.ItemGroups)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("item_groups_audit_user_id_fkey");

            entity.HasOne(d => d.Tax).WithMany(p => p.ItemGroups)
                .HasForeignKey(d => d.TaxId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_groups_tax_id_fkey");
        });

        modelBuilder.Entity<ItemOpeningInventory>(entity =>
        {
            entity.HasKey(e => e.ItemOpeningInventoryId).HasName("item_opening_inventory_pkey");

            entity.ToTable("item_opening_inventory", "core");

            entity.Property(e => e.ItemOpeningInventoryId).HasColumnName("item_opening_inventory_id");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BaseQuantity).HasColumnName("base_quantity");
            entity.Property(e => e.BaseUnitId).HasColumnName("base_unit_id");
            entity.Property(e => e.EntryTs).HasColumnName("entry_ts");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.ItemOpeningInventories)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("item_opening_inventory_audit_user_id_fkey");

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.ItemOpeningInventoryBaseUnits)
                .HasForeignKey(d => d.BaseUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_opening_inventory_base_unit_id_fkey");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemOpeningInventories)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_opening_inventory_item_id_fkey");

            entity.HasOne(d => d.Store).WithMany(p => p.ItemOpeningInventories)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_opening_inventory_store_id_fkey");

            entity.HasOne(d => d.Unit).WithMany(p => p.ItemOpeningInventoryUnits)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_opening_inventory_unit_id_fkey");
        });

        modelBuilder.Entity<ItemSellingPrice>(entity =>
        {
            entity.HasKey(e => e.ItemSellingPriceId).HasName("item_selling_prices_pkey");

            entity.ToTable("item_selling_prices", "core");

            entity.Property(e => e.ItemSellingPriceId).HasColumnName("item_selling_price_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.IncludesTax).HasColumnName("includes_tax");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.PriceTypeId).HasColumnName("price_type_id");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.ItemSellingPrices)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("item_selling_prices_audit_user_id_fkey");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemSellingPrices)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_selling_prices_item_id_fkey");

            entity.HasOne(d => d.PartyType).WithMany(p => p.ItemSellingPrices)
                .HasForeignKey(d => d.PartyTypeId)
                .HasConstraintName("item_selling_prices_party_type_id_fkey");

            entity.HasOne(d => d.PriceType).WithMany(p => p.ItemSellingPrices)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("item_selling_prices_price_type_id_fkey");

            entity.HasOne(d => d.Unit).WithMany(p => p.ItemSellingPrices)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_selling_prices_unit_id_fkey");
        });

        modelBuilder.Entity<LeadSource>(entity =>
        {
            entity.HasKey(e => e.LeadSourceId).HasName("lead_sources_pkey");

            entity.ToTable("lead_sources", "crm");

            entity.Property(e => e.LeadSourceId).HasColumnName("lead_source_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.LeadSourceCode)
                .HasMaxLength(12)
                .HasColumnName("lead_source_code");
            entity.Property(e => e.LeadSourceName)
                .HasMaxLength(128)
                .HasColumnName("lead_source_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.LeadSources)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("lead_sources_audit_user_id_fkey");
        });

        modelBuilder.Entity<LeadStatus>(entity =>
        {
            entity.HasKey(e => e.LeadStatusId).HasName("lead_statuses_pkey");

            entity.ToTable("lead_statuses", "crm");

            entity.Property(e => e.LeadStatusId).HasColumnName("lead_status_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.LeadStatusCode)
                .HasMaxLength(12)
                .HasColumnName("lead_status_code");
            entity.Property(e => e.LeadStatusName)
                .HasMaxLength(128)
                .HasColumnName("lead_status_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.LeadStatuses)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("lead_statuses_audit_user_id_fkey");
        });

        modelBuilder.Entity<LockOut>(entity =>
        {
            entity.HasKey(e => e.LockOutId).HasName("lock_outs_pkey");

            entity.ToTable("lock_outs", "policy");

            entity.Property(e => e.LockOutId).HasColumnName("lock_out_id");
            entity.Property(e => e.LockOutTill)
                .HasDefaultValueSql("(now() + '00:05:00'::interval)")
                .HasColumnName("lock_out_till");
            entity.Property(e => e.LockOutTime)
                .HasDefaultValueSql("now()")
                .HasColumnName("lock_out_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.LockOuts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lock_outs_user_id_fkey");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("logins_pkey");

            entity.ToTable("logins", "audit");

            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.Browser)
                .HasMaxLength(500)
                .HasColumnName("browser");
            entity.Property(e => e.Culture)
                .HasMaxLength(12)
                .HasColumnName("culture");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("ip_address");
            entity.Property(e => e.LoginDateTime)
                .HasDefaultValueSql("now()")
                .HasColumnName("login_date_time");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.RemoteUser)
                .HasMaxLength(50)
                .HasColumnName("remote_user");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Office).WithMany(p => p.Logins)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("logins_office_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Logins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("logins_user_id_fkey");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("menus_pkey");

            entity.ToTable("menus", "core");

            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MenuCode)
                .HasMaxLength(12)
                .HasColumnName("menu_code");
            entity.Property(e => e.MenuText)
                .HasMaxLength(250)
                .HasColumnName("menu_text");
            entity.Property(e => e.ParentMenuId).HasColumnName("parent_menu_id");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Menus)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("menus_audit_user_id_fkey");

            entity.HasOne(d => d.ParentMenu).WithMany(p => p.InverseParentMenu)
                .HasForeignKey(d => d.ParentMenuId)
                .HasConstraintName("menus_parent_menu_id_fkey");
        });

        modelBuilder.Entity<MenuAccess>(entity =>
        {
            entity.HasKey(e => e.AccessId).HasName("menu_access_pkey");

            entity.ToTable("menu_access", "policy");

            entity.Property(e => e.AccessId).HasColumnName("access_id");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Menu).WithMany(p => p.MenuAccesses)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("menu_access_menu_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.MenuAccesses)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("menu_access_office_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MenuAccesses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("menu_access_user_id_fkey");
        });

        modelBuilder.Entity<MenuLocale>(entity =>
        {
            entity.HasKey(e => e.MenuLocaleId).HasName("menu_locale_pkey");

            entity.ToTable("menu_locale", "core");

            entity.Property(e => e.MenuLocaleId).HasColumnName("menu_locale_id");
            entity.Property(e => e.Culture)
                .HasMaxLength(12)
                .HasColumnName("culture");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.MenuText)
                .HasMaxLength(250)
                .HasColumnName("menu_text");

            entity.HasOne(d => d.Menu).WithMany(p => p.MenuLocales)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("menu_locale_menu_id_fkey");
        });

        modelBuilder.Entity<MenuPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyId).HasName("menu_policy_pkey");

            entity.ToTable("menu_policy", "policy");

            entity.Property(e => e.PolicyId).HasColumnName("policy_id");
            entity.Property(e => e.InheritInChildOffices).HasColumnName("inherit_in_child_offices");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Scope)
                .HasMaxLength(12)
                .HasColumnName("scope");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Menu).WithMany(p => p.MenuPolicies)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("menu_policy_menu_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.MenuPolicies)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("menu_policy_office_id_fkey");

            entity.HasOne(d => d.Role).WithMany(p => p.MenuPolicies)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("menu_policy_role_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MenuPolicies)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("menu_policy_user_id_fkey");
        });

        modelBuilder.Entity<NonGlStockDetail>(entity =>
        {
            entity.HasKey(e => e.NonGlStockDetailId).HasName("non_gl_stock_details_pkey");

            entity.ToTable("non_gl_stock_details", "transactions");

            entity.Property(e => e.NonGlStockDetailId).HasColumnName("non_gl_stock_detail_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BaseQuantity).HasColumnName("base_quantity");
            entity.Property(e => e.BaseUnitId).HasColumnName("base_unit_id");
            entity.Property(e => e.Discount)
                .HasColumnType("money")
                .HasColumnName("discount");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.NonGlStockMasterId).HasColumnName("non_gl_stock_master_id");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Tax)
                .HasColumnType("money")
                .HasColumnName("tax");
            entity.Property(e => e.TaxRate).HasColumnName("tax_rate");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.NonGlStockDetails)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("non_gl_stock_details_audit_user_id_fkey");

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.NonGlStockDetailBaseUnits)
                .HasForeignKey(d => d.BaseUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_details_base_unit_id_fkey");

            entity.HasOne(d => d.Item).WithMany(p => p.NonGlStockDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_details_item_id_fkey");

            entity.HasOne(d => d.NonGlStockMaster).WithMany(p => p.NonGlStockDetails)
                .HasForeignKey(d => d.NonGlStockMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_details_non_gl_stock_master_id_fkey");

            entity.HasOne(d => d.Unit).WithMany(p => p.NonGlStockDetailUnits)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_details_unit_id_fkey");
        });

        modelBuilder.Entity<NonGlStockMaster>(entity =>
        {
            entity.HasKey(e => e.NonGlStockMasterId).HasName("non_gl_stock_master_pkey");

            entity.ToTable("non_gl_stock_master", "transactions");

            entity.Property(e => e.NonGlStockMasterId).HasColumnName("non_gl_stock_master_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Book)
                .HasMaxLength(48)
                .HasColumnName("book");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.PartyId).HasColumnName("party_id");
            entity.Property(e => e.PriceTypeId).HasColumnName("price_type_id");
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(24)
                .HasColumnName("reference_number");
            entity.Property(e => e.StatementReference).HasColumnName("statement_reference");
            entity.Property(e => e.TransactionTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("transaction_ts");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.ValueDate).HasColumnName("value_date");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.NonGlStockMasterAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("non_gl_stock_master_audit_user_id_fkey");

            entity.HasOne(d => d.Login).WithMany(p => p.NonGlStockMasters)
                .HasForeignKey(d => d.LoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_master_login_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.NonGlStockMasters)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_master_office_id_fkey");

            entity.HasOne(d => d.Party).WithMany(p => p.NonGlStockMasters)
                .HasForeignKey(d => d.PartyId)
                .HasConstraintName("non_gl_stock_master_party_id_fkey");

            entity.HasOne(d => d.PriceType).WithMany(p => p.NonGlStockMasters)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("non_gl_stock_master_price_type_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.NonGlStockMasterUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_master_user_id_fkey");
        });

        modelBuilder.Entity<NonGlStockMasterRelation>(entity =>
        {
            entity.HasKey(e => e.NonGlStockMasterRelationId).HasName("non_gl_stock_master_relations_pkey");

            entity.ToTable("non_gl_stock_master_relations", "transactions");

            entity.Property(e => e.NonGlStockMasterRelationId)
                .HasDefaultValueSql("nextval('transactions.non_gl_stock_master_relations_non_gl_stock_master_relation__seq'::regclass)")
                .HasColumnName("non_gl_stock_master_relation_id");
            entity.Property(e => e.OrderNonGlStockMasterId).HasColumnName("order_non_gl_stock_master_id");
            entity.Property(e => e.QuotationNonGlStockMasterId).HasColumnName("quotation_non_gl_stock_master_id");

            entity.HasOne(d => d.OrderNonGlStockMaster).WithMany(p => p.NonGlStockMasterRelationOrderNonGlStockMasters)
                .HasForeignKey(d => d.OrderNonGlStockMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_master_relations_order_non_gl_stock_master_id_fkey");

            entity.HasOne(d => d.QuotationNonGlStockMaster).WithMany(p => p.NonGlStockMasterRelationQuotationNonGlStockMasters)
                .HasForeignKey(d => d.QuotationNonGlStockMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("non_gl_stock_master_relations_quotation_non_gl_stock_maste_fkey");
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity.HasKey(e => e.OfficeId).HasName("offices_pkey");

            entity.ToTable("offices", "office");

            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(128)
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(128)
                .HasColumnName("address_line_2");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(12)
                .HasDefaultValueSql("'NPR'::character varying")
                .HasColumnName("currency_code");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(24)
                .HasColumnName("fax");
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .HasColumnName("nick_name");
            entity.Property(e => e.OfficeCode)
                .HasMaxLength(12)
                .HasColumnName("office_code");
            entity.Property(e => e.OfficeName)
                .HasMaxLength(150)
                .HasColumnName("office_name");
            entity.Property(e => e.PanNumber)
                .HasMaxLength(24)
                .HasColumnName("pan_number");
            entity.Property(e => e.ParentOfficeId).HasColumnName("parent_office_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasColumnName("phone");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(24)
                .HasColumnName("registration_number");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("url");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(24)
                .HasColumnName("zip_code");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Offices)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("offices_audit_user_id_fkey");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.Offices)
                .HasForeignKey(d => d.CurrencyCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("offices_currencies_fk");

            entity.HasOne(d => d.ParentOffice).WithMany(p => p.InverseParentOffice)
                .HasForeignKey(d => d.ParentOfficeId)
                .HasConstraintName("offices_parent_office_id_fkey");
        });

        modelBuilder.Entity<OfficeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("office_view", "office");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(128)
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(128)
                .HasColumnName("address_line_2");
            entity.Property(e => e.AuditTs).HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(12)
                .HasColumnName("currency_code");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(24)
                .HasColumnName("fax");
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .HasColumnName("nick_name");
            entity.Property(e => e.OfficeCode)
                .HasMaxLength(12)
                .HasColumnName("office_code");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.OfficeName)
                .HasMaxLength(150)
                .HasColumnName("office_name");
            entity.Property(e => e.PanNumber)
                .HasMaxLength(24)
                .HasColumnName("pan_number");
            entity.Property(e => e.ParentOfficeId).HasColumnName("parent_office_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasColumnName("phone");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(24)
                .HasColumnName("registration_number");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("url");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(24)
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<OpportunityStage>(entity =>
        {
            entity.HasKey(e => e.OpportunityStageId).HasName("opportunity_stages_pkey");

            entity.ToTable("opportunity_stages", "crm");

            entity.Property(e => e.OpportunityStageId).HasColumnName("opportunity_stage_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.OpportunityStageCode)
                .HasMaxLength(12)
                .HasColumnName("opportunity_stage_code");
            entity.Property(e => e.OpportunityStageName)
                .HasMaxLength(50)
                .HasColumnName("opportunity_stage_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.OpportunityStages)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("opportunity_stages_audit_user_id_fkey");
        });

        modelBuilder.Entity<Party>(entity =>
        {
            entity.HasKey(e => e.PartyId).HasName("parties_pkey");

            entity.ToTable("parties", "core");

            entity.Property(e => e.PartyId).HasColumnName("party_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(128)
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(128)
                .HasColumnName("address_line_2");
            entity.Property(e => e.AllowCredit).HasColumnName("allow_credit");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Cell)
                .HasMaxLength(24)
                .HasColumnName("cell");
            entity.Property(e => e.ChargeInterest).HasColumnName("charge_interest");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CstNumber)
                .HasMaxLength(50)
                .HasColumnName("cst_number");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(24)
                .HasColumnName("fax");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.InterestCompoundingFrequencyId).HasColumnName("interest_compounding_frequency_id");
            entity.Property(e => e.InterestRate).HasColumnName("interest_rate");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MaximumCreditAmount)
                .HasColumnType("money")
                .HasColumnName("maximum_credit_amount");
            entity.Property(e => e.MaximumCreditPeriod).HasColumnName("maximum_credit_period");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middle_name");
            entity.Property(e => e.PanNumber)
                .HasMaxLength(50)
                .HasColumnName("pan_number");
            entity.Property(e => e.PartyCode)
                .HasMaxLength(12)
                .HasColumnName("party_code");
            entity.Property(e => e.PartyName).HasColumnName("party_name");
            entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasColumnName("phone");
            entity.Property(e => e.SstNumber)
                .HasMaxLength(50)
                .HasColumnName("sst_number");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("url");

            entity.HasOne(d => d.Account).WithMany(p => p.Parties)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("parties_account_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Parties)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("parties_audit_user_id_fkey");

            entity.HasOne(d => d.InterestCompoundingFrequency).WithMany(p => p.Parties)
                .HasForeignKey(d => d.InterestCompoundingFrequencyId)
                .HasConstraintName("parties_interest_compounding_frequency_id_fkey");

            entity.HasOne(d => d.PartyType).WithMany(p => p.Parties)
                .HasForeignKey(d => d.PartyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("parties_party_type_id_fkey");
        });

        modelBuilder.Entity<PartyType>(entity =>
        {
            entity.HasKey(e => e.PartyTypeId).HasName("party_types_pkey");

            entity.ToTable("party_types", "core");

            entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.IsSupplier).HasColumnName("is_supplier");
            entity.Property(e => e.PartyTypeCode)
                .HasMaxLength(12)
                .HasColumnName("party_type_code");
            entity.Property(e => e.PartyTypeName)
                .HasMaxLength(50)
                .HasColumnName("party_type_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.PartyTypes)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("party_types_audit_user_id_fkey");
        });

        modelBuilder.Entity<PriceType>(entity =>
        {
            entity.HasKey(e => e.PriceTypeId).HasName("price_types_pkey");

            entity.ToTable("price_types", "core");

            entity.Property(e => e.PriceTypeId).HasColumnName("price_type_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.PriceTypeCode)
                .HasMaxLength(12)
                .HasColumnName("price_type_code");
            entity.Property(e => e.PriceTypeName)
                .HasMaxLength(50)
                .HasColumnName("price_type_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.PriceTypes)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("price_types_audit_user_id_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("roles_pkey");

            entity.ToTable("roles", "office");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.IsSystem).HasColumnName("is_system");
            entity.Property(e => e.RoleCode)
                .HasMaxLength(12)
                .HasColumnName("role_code");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Roles)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("roles_audit_user_id_fkey");
        });

        modelBuilder.Entity<RoleView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("role_view", "office");

            entity.Property(e => e.RoleCode)
                .HasMaxLength(12)
                .HasColumnName("role_code");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.HasKey(e => e.ShipperId).HasName("shippers_pkey");

            entity.ToTable("shippers", "core");

            entity.Property(e => e.ShipperId).HasColumnName("shipper_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(128)
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(128)
                .HasColumnName("address_line_2");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Cell)
                .HasMaxLength(50)
                .HasColumnName("cell");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(128)
                .HasColumnName("company_name");
            entity.Property(e => e.ContactAddressLine1)
                .HasMaxLength(128)
                .HasColumnName("contact_address_line_1");
            entity.Property(e => e.ContactAddressLine2)
                .HasMaxLength(128)
                .HasColumnName("contact_address_line_2");
            entity.Property(e => e.ContactCell)
                .HasMaxLength(50)
                .HasColumnName("contact_cell");
            entity.Property(e => e.ContactCity)
                .HasMaxLength(50)
                .HasColumnName("contact_city");
            entity.Property(e => e.ContactCountry)
                .HasMaxLength(50)
                .HasColumnName("contact_country");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(128)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(50)
                .HasColumnName("contact_person");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .HasColumnName("contact_phone");
            entity.Property(e => e.ContactState)
                .HasMaxLength(50)
                .HasColumnName("contact_state");
            entity.Property(e => e.ContactStreet)
                .HasMaxLength(50)
                .HasColumnName("contact_street");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CstNumber)
                .HasMaxLength(50)
                .HasColumnName("cst_number");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("email");
            entity.Property(e => e.FactoryAddress)
                .HasMaxLength(250)
                .HasColumnName("factory_address");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.PanNumber)
                .HasMaxLength(50)
                .HasColumnName("pan_number");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.ShipperCode)
                .HasMaxLength(12)
                .HasColumnName("shipper_code");
            entity.Property(e => e.ShipperName)
                .HasMaxLength(150)
                .HasColumnName("shipper_name");
            entity.Property(e => e.SstNumber)
                .HasMaxLength(50)
                .HasColumnName("sst_number");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("url");

            entity.HasOne(d => d.Account).WithMany(p => p.Shippers)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("shippers_account_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Shippers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("shippers_audit_user_id_fkey");
        });

        modelBuilder.Entity<ShippingAddress>(entity =>
        {
            entity.HasKey(e => e.ShippingAddressId).HasName("shipping_addresses_pkey");

            entity.ToTable("shipping_addresses", "core");

            entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(128)
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(128)
                .HasColumnName("address_line_2");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.City)
                .HasMaxLength(128)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(128)
                .HasColumnName("country");
            entity.Property(e => e.PartyId).HasColumnName("party_id");
            entity.Property(e => e.ShippingAddressCode)
                .HasMaxLength(24)
                .HasColumnName("shipping_address_code");
            entity.Property(e => e.State)
                .HasMaxLength(128)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(128)
                .HasColumnName("street");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.ShippingAddresses)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("shipping_addresses_audit_user_id_fkey");

            entity.HasOne(d => d.Party).WithMany(p => p.ShippingAddresses)
                .HasForeignKey(d => d.PartyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("shipping_addresses_party_id_fkey");
        });

        modelBuilder.Entity<StockDetail>(entity =>
        {
            entity.HasKey(e => e.StockMasterDetailId).HasName("stock_details_pkey");

            entity.ToTable("stock_details", "transactions");

            entity.Property(e => e.StockMasterDetailId).HasColumnName("stock_master_detail_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.BaseQuantity).HasColumnName("base_quantity");
            entity.Property(e => e.BaseUnitId).HasColumnName("base_unit_id");
            entity.Property(e => e.Discount)
                .HasColumnType("money")
                .HasColumnName("discount");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.StockMasterId).HasColumnName("stock_master_id");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Tax)
                .HasColumnType("money")
                .HasColumnName("tax");
            entity.Property(e => e.TaxRate).HasColumnName("tax_rate");
            entity.Property(e => e.TranType)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("tran_type");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.StockDetails)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("stock_details_audit_user_id_fkey");

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.StockDetailBaseUnits)
                .HasForeignKey(d => d.BaseUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_details_base_unit_id_fkey");

            entity.HasOne(d => d.Item).WithMany(p => p.StockDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_details_item_id_fkey");

            entity.HasOne(d => d.StockMaster).WithMany(p => p.StockDetails)
                .HasForeignKey(d => d.StockMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_details_stock_master_id_fkey");

            entity.HasOne(d => d.Store).WithMany(p => p.StockDetails)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("stock_details_store_id_fkey");

            entity.HasOne(d => d.Unit).WithMany(p => p.StockDetailUnits)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_details_unit_id_fkey");
        });

        modelBuilder.Entity<StockMaster>(entity =>
        {
            entity.HasKey(e => e.StockMasterId).HasName("stock_master_pkey");

            entity.ToTable("stock_master", "transactions");

            entity.Property(e => e.StockMasterId).HasColumnName("stock_master_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CashRepositoryId).HasColumnName("cash_repository_id");
            entity.Property(e => e.IsCredit).HasColumnName("is_credit");
            entity.Property(e => e.PartyId).HasColumnName("party_id");
            entity.Property(e => e.PriceTypeId).HasColumnName("price_type_id");
            entity.Property(e => e.ShipperId).HasColumnName("shipper_id");
            entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");
            entity.Property(e => e.ShippingCharge)
                .HasColumnType("money")
                .HasColumnName("shipping_charge");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.TransactionMasterId).HasColumnName("transaction_master_id");

            entity.HasOne(d => d.Agent).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("stock_master_agent_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("stock_master_audit_user_id_fkey");

            entity.HasOne(d => d.CashRepository).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.CashRepositoryId)
                .HasConstraintName("stock_master_cash_repository_id_fkey");

            entity.HasOne(d => d.Party).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.PartyId)
                .HasConstraintName("stock_master_party_id_fkey");

            entity.HasOne(d => d.PriceType).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.PriceTypeId)
                .HasConstraintName("stock_master_price_type_id_fkey");

            entity.HasOne(d => d.Shipper).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.ShipperId)
                .HasConstraintName("stock_master_shipper_id_fkey");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.ShippingAddressId)
                .HasConstraintName("stock_master_shipping_address_id_fkey");

            entity.HasOne(d => d.Store).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("stock_master_store_id_fkey");

            entity.HasOne(d => d.TransactionMaster).WithMany(p => p.StockMasters)
                .HasForeignKey(d => d.TransactionMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_master_transaction_master_id_fkey");
        });

        modelBuilder.Entity<StockMasterNonGlRelation>(entity =>
        {
            entity.HasKey(e => e.StockMasterNonGlRelationId).HasName("stock_master_non_gl_relations_pkey");

            entity.ToTable("stock_master_non_gl_relations", "transactions");

            entity.Property(e => e.StockMasterNonGlRelationId)
                .HasDefaultValueSql("nextval('transactions.stock_master_non_gl_relations_stock_master_non_gl_relation__seq'::regclass)")
                .HasColumnName("stock_master_non_gl_relation_id");
            entity.Property(e => e.NonGlStockMasterId).HasColumnName("non_gl_stock_master_id");
            entity.Property(e => e.StockMasterId).HasColumnName("stock_master_id");

            entity.HasOne(d => d.NonGlStockMaster).WithMany(p => p.StockMasterNonGlRelations)
                .HasForeignKey(d => d.NonGlStockMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_master_non_gl_relations_non_gl_stock_master_id_fkey");

            entity.HasOne(d => d.StockMaster).WithMany(p => p.StockMasterNonGlRelations)
                .HasForeignKey(d => d.StockMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stock_master_non_gl_relations_stock_master_id_fkey");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("stores_pkey");

            entity.ToTable("stores", "office");

            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.AllowSales)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("allow_sales");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.StoreCode)
                .HasMaxLength(12)
                .HasColumnName("store_code");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .HasColumnName("store_name");
            entity.Property(e => e.StoreTypeId).HasColumnName("store_type_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Stores)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("stores_audit_user_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.Stores)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stores_office_id_fkey");

            entity.HasOne(d => d.StoreType).WithMany(p => p.Stores)
                .HasForeignKey(d => d.StoreTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stores_store_type_id_fkey");
        });

        modelBuilder.Entity<StorePolicy>(entity =>
        {
            entity.HasKey(e => e.StorePolicyId).HasName("store_policies_pkey");

            entity.ToTable("store_policies", "policy");

            entity.Property(e => e.StorePolicyId).HasColumnName("store_policy_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WrittenByUserId).HasColumnName("written_by_user_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.StorePolicyAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("store_policies_audit_user_id_fkey");

            entity.HasOne(d => d.WrittenByUser).WithMany(p => p.StorePolicyWrittenByUsers)
                .HasForeignKey(d => d.WrittenByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("store_policies_written_by_user_id_fkey");
        });

        modelBuilder.Entity<StorePolicyDetail>(entity =>
        {
            entity.HasKey(e => e.StorePolicyDetailId).HasName("store_policy_details_pkey");

            entity.ToTable("store_policy_details", "policy");

            entity.Property(e => e.StorePolicyDetailId).HasColumnName("store_policy_detail_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.StorePolicyId).HasColumnName("store_policy_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.StorePolicyDetailAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("store_policy_details_audit_user_id_fkey");

            entity.HasOne(d => d.Store).WithMany(p => p.StorePolicyDetails)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("store_policy_details_store_id_fkey");

            entity.HasOne(d => d.StorePolicy).WithMany(p => p.StorePolicyDetails)
                .HasForeignKey(d => d.StorePolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("store_policy_details_store_policy_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.StorePolicyDetailUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("store_policy_details_user_id_fkey");
        });

        modelBuilder.Entity<StoreType>(entity =>
        {
            entity.HasKey(e => e.StoreTypeId).HasName("store_types_pkey");

            entity.ToTable("store_types", "office");

            entity.Property(e => e.StoreTypeId).HasColumnName("store_type_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.StoreTypeCode)
                .HasMaxLength(12)
                .HasColumnName("store_type_code");
            entity.Property(e => e.StoreTypeName)
                .HasMaxLength(50)
                .HasColumnName("store_type_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.StoreTypes)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("store_types_audit_user_id_fkey");
        });

        modelBuilder.Entity<StoreView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("store_view", "office");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.AllowSales).HasColumnName("allow_sales");
            entity.Property(e => e.AuditTs).HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.StoreCode)
                .HasMaxLength(12)
                .HasColumnName("store_code");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .HasColumnName("store_name");
            entity.Property(e => e.StoreTypeId).HasColumnName("store_type_id");
        });

        modelBuilder.Entity<SwitchCategory>(entity =>
        {
            entity.HasKey(e => e.SwitchCategoryId).HasName("switch_categories_pkey");

            entity.ToTable("switch_categories", "core");

            entity.Property(e => e.SwitchCategoryId).HasColumnName("switch_category_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.SwitchCategoryName)
                .HasMaxLength(128)
                .HasColumnName("switch_category_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.SwitchCategories)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("switch_categories_audit_user_id_fkey");
        });

        modelBuilder.Entity<TaxType>(entity =>
        {
            entity.HasKey(e => e.TaxTypeId).HasName("tax_types_pkey");

            entity.ToTable("tax_types", "core");

            entity.Property(e => e.TaxTypeId).HasColumnName("tax_type_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.TaxTypeCode)
                .HasMaxLength(12)
                .HasColumnName("tax_type_code");
            entity.Property(e => e.TaxTypeName)
                .HasMaxLength(50)
                .HasColumnName("tax_type_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.TaxTypes)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("tax_types_audit_user_id_fkey");
        });

        modelBuilder.Entity<Taxis>(entity =>
        {
            entity.HasKey(e => e.TaxId).HasName("taxes_pkey");

            entity.ToTable("taxes", "core");

            entity.Property(e => e.TaxId).HasColumnName("tax_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(12)
                .HasColumnName("tax_code");
            entity.Property(e => e.TaxName)
                .HasMaxLength(50)
                .HasColumnName("tax_name");
            entity.Property(e => e.TaxTypeId).HasColumnName("tax_type_id");

            entity.HasOne(d => d.Account).WithMany(p => p.Taxes)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("taxes_account_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Taxes)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("taxes_audit_user_id_fkey");

            entity.HasOne(d => d.TaxType).WithMany(p => p.Taxes)
                .HasForeignKey(d => d.TaxTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("taxes_tax_type_id_fkey");
        });

        modelBuilder.Entity<TransactionDetail>(entity =>
        {
            entity.HasKey(e => e.TransactionDetailId).HasName("transaction_details_pkey");

            entity.ToTable("transaction_details", "transactions");

            entity.Property(e => e.TransactionDetailId).HasColumnName("transaction_detail_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CashRepositoryId).HasColumnName("cash_repository_id");
            entity.Property(e => e.StatementReference).HasColumnName("statement_reference");
            entity.Property(e => e.TranType)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("tran_type");
            entity.Property(e => e.TransactionMasterId).HasColumnName("transaction_master_id");

            entity.HasOne(d => d.Account).WithMany(p => p.TransactionDetails)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_details_account_id_fkey");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.TransactionDetails)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("transaction_details_audit_user_id_fkey");

            entity.HasOne(d => d.CashRepository).WithMany(p => p.TransactionDetails)
                .HasForeignKey(d => d.CashRepositoryId)
                .HasConstraintName("transaction_details_cash_repository_id_fkey");

            entity.HasOne(d => d.TransactionMaster).WithMany(p => p.TransactionDetails)
                .HasForeignKey(d => d.TransactionMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_details_transaction_master_id_fkey");
        });

        modelBuilder.Entity<TransactionMaster>(entity =>
        {
            entity.HasKey(e => e.TransactionMasterId).HasName("transaction_master_pkey");

            entity.ToTable("transaction_master", "transactions");

            entity.Property(e => e.TransactionMasterId).HasColumnName("transaction_master_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.Book)
                .HasMaxLength(50)
                .HasColumnName("book");
            entity.Property(e => e.CostCenterId).HasColumnName("cost_center_id");
            entity.Property(e => e.LastVerifiedOn).HasColumnName("last_verified_on");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(24)
                .HasColumnName("reference_number");
            entity.Property(e => e.StatementReference).HasColumnName("statement_reference");
            entity.Property(e => e.SysUserId).HasColumnName("sys_user_id");
            entity.Property(e => e.TransactionCode)
                .HasMaxLength(50)
                .HasColumnName("transaction_code");
            entity.Property(e => e.TransactionCounter).HasColumnName("transaction_counter");
            entity.Property(e => e.TransactionTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("transaction_ts");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.ValueDate).HasColumnName("value_date");
            entity.Property(e => e.VerificationReason)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("verification_reason");
            entity.Property(e => e.VerificationStatusId).HasColumnName("verification_status_id");
            entity.Property(e => e.VerifiedByUserId).HasColumnName("verified_by_user_id");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.TransactionMasterAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("transaction_master_audit_user_id_fkey");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.TransactionMasters)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("transaction_master_cost_center_id_fkey");

            entity.HasOne(d => d.Login).WithMany(p => p.TransactionMasters)
                .HasForeignKey(d => d.LoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_master_login_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.TransactionMasters)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_master_office_id_fkey");

            entity.HasOne(d => d.SysUser).WithMany(p => p.TransactionMasterSysUsers)
                .HasForeignKey(d => d.SysUserId)
                .HasConstraintName("transaction_master_sys_user_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.TransactionMasterUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_master_user_id_fkey");

            entity.HasOne(d => d.VerificationStatus).WithMany(p => p.TransactionMasters)
                .HasForeignKey(d => d.VerificationStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_master_verification_status_id_fkey");

            entity.HasOne(d => d.VerifiedByUser).WithMany(p => p.TransactionMasterVerifiedByUsers)
                .HasForeignKey(d => d.VerifiedByUserId)
                .HasConstraintName("transaction_master_verified_by_user_id_fkey");
        });

        modelBuilder.Entity<TrialBalanceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("trial_balance_view", "transactions");

            entity.Property(e => e.Credit)
                .HasColumnType("money")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("money")
                .HasColumnName("debit");
            entity.Property(e => e.GetAccountName).HasColumnName("get_account_name");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("units_pkey");

            entity.ToTable("units", "core");

            entity.Property(e => e.UnitId).HasColumnName("unit_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(12)
                .HasColumnName("unit_code");
            entity.Property(e => e.UnitName)
                .HasMaxLength(50)
                .HasColumnName("unit_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Units)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("units_audit_user_id_fkey");
        });

        modelBuilder.Entity<UnitView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("unit_view", "core");

            entity.Property(e => e.AuditTs).HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(12)
                .HasColumnName("unit_code");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");
            entity.Property(e => e.UnitName)
                .HasMaxLength(50)
                .HasColumnName("unit_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("users_pkey");

            entity.ToTable("users", "office");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .HasColumnName("full_name");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.InverseAuditUser)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("users_audit_user_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.Users)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_office_id_fkey");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_role_id_fkey");
        });

        modelBuilder.Entity<VerificationStatus>(entity =>
        {
            entity.HasKey(e => e.VerificationStatusId).HasName("verification_statuses_pkey");

            entity.ToTable("verification_statuses", "core");

            entity.Property(e => e.VerificationStatusId)
                .ValueGeneratedNever()
                .HasColumnName("verification_status_id");
            entity.Property(e => e.VerificationStatusName)
                .HasMaxLength(128)
                .HasColumnName("verification_status_name");
        });

        modelBuilder.Entity<VoucherVerificationPolicy>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("voucher_verification_policy_pkey");

            entity.ToTable("voucher_verification_policy", "policy");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CanSelfVerify).HasColumnName("can_self_verify");
            entity.Property(e => e.CanVerifyGlTransactions).HasColumnName("can_verify_gl_transactions");
            entity.Property(e => e.CanVerifyPurchaseTransactions).HasColumnName("can_verify_purchase_transactions");
            entity.Property(e => e.CanVerifySalesTransactions).HasColumnName("can_verify_sales_transactions");
            entity.Property(e => e.EffectiveFrom).HasColumnName("effective_from");
            entity.Property(e => e.EndsOn).HasColumnName("ends_on");
            entity.Property(e => e.GlVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("gl_verification_limit");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.PurchaseVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("purchase_verification_limit");
            entity.Property(e => e.SalesVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("sales_verification_limit");
            entity.Property(e => e.SelfVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("self_verification_limit");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.VoucherVerificationPolicyAuditUsers)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("voucher_verification_policy_audit_user_id_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.VoucherVerificationPolicyUser)
                .HasForeignKey<VoucherVerificationPolicy>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("voucher_verification_policy_user_id_fkey");
        });

        modelBuilder.Entity<VoucherVerificationPolicyView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("voucher_verification_policy_view", "policy");

            entity.Property(e => e.CanSelfVerify).HasColumnName("can_self_verify");
            entity.Property(e => e.CanVerifyGlTransactions).HasColumnName("can_verify_gl_transactions");
            entity.Property(e => e.CanVerifyPurchaseTransactions).HasColumnName("can_verify_purchase_transactions");
            entity.Property(e => e.CanVerifySalesTransactions).HasColumnName("can_verify_sales_transactions");
            entity.Property(e => e.EffectiveFrom).HasColumnName("effective_from");
            entity.Property(e => e.EndsOn).HasColumnName("ends_on");
            entity.Property(e => e.GlVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("gl_verification_limit");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.PurchaseVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("purchase_verification_limit");
            entity.Property(e => e.SalesVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("sales_verification_limit");
            entity.Property(e => e.SelfVerificationLimit)
                .HasColumnType("money")
                .HasColumnName("self_verification_limit");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<WorkCenter>(entity =>
        {
            entity.HasKey(e => e.WorkCenterId).HasName("work_centers_pkey");

            entity.ToTable("work_centers", "office");

            entity.Property(e => e.WorkCenterId).HasColumnName("work_center_id");
            entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("now()")
                .HasColumnName("audit_ts");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.OfficeId).HasColumnName("office_id");
            entity.Property(e => e.WorkCenterCode)
                .HasMaxLength(12)
                .HasColumnName("work_center_code");
            entity.Property(e => e.WorkCenterName)
                .HasMaxLength(128)
                .HasColumnName("work_center_name");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.WorkCenters)
                .HasForeignKey(d => d.AuditUserId)
                .HasConstraintName("work_centers_audit_user_id_fkey");

            entity.HasOne(d => d.Office).WithMany(p => p.WorkCenters)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("work_centers_office_id_fkey");
        });

        modelBuilder.Entity<WorkCenterView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("work_center_view", "office");

            entity.Property(e => e.Office).HasColumnName("office");
            entity.Property(e => e.WorkCenterCode)
                .HasMaxLength(12)
                .HasColumnName("work_center_code");
            entity.Property(e => e.WorkCenterId).HasColumnName("work_center_id");
            entity.Property(e => e.WorkCenterName)
                .HasMaxLength(128)
                .HasColumnName("work_center_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
