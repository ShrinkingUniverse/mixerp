using Microsoft.EntityFrameworkCore;
using MixERP.Net.DBFactory.EF.Models;
using Npgsql;

namespace MixERP.Net.DBFactory.EF.Context
{
    public interface IMixerpContext
    {
        DbSet<AccountMaster> AccountMasters { get; set; }
        DbSet<AccountParameter> AccountParameters { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<AccountsView> AccountsViews { get; set; }
        DbSet<AccountView> AccountViews { get; set; }
        DbSet<AgeingSlab> AgeingSlabs { get; set; }
        DbSet<AgentBonusSetup> AgentBonusSetups { get; set; }
        DbSet<AgentBonusSetupView> AgentBonusSetupViews { get; set; }
        DbSet<Agent> Agents { get; set; }
        DbSet<AgentView> AgentViews { get; set; }
        DbSet<Attachment> Attachments { get; set; }
        DbSet<AutoVerificationPolicy> AutoVerificationPolicies { get; set; }
        DbSet<AutoVerificationPolicyView> AutoVerificationPolicyViews { get; set; }
        DbSet<BankAccount> BankAccounts { get; set; }
        DbSet<BankAccountView> BankAccountViews { get; set; }
        DbSet<BonusSlabDetail> BonusSlabDetails { get; set; }
        DbSet<BonusSlabDetailView> BonusSlabDetailViews { get; set; }
        DbSet<BonusSlab> BonusSlabs { get; set; }
        DbSet<BonusSlabView> BonusSlabViews { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Cashier> Cashiers { get; set; }
        DbSet<CashRepository> CashRepositories { get; set; }
        DbSet<CompoundUnit> CompoundUnits { get; set; }
        DbSet<CompoundUnitView> CompoundUnitViews { get; set; }
        DbSet<CostCenter> CostCenters { get; set; }
        DbSet<CostCenterView> CostCenterViews { get; set; }
        DbSet<Counter> Counters { get; set; }
        DbSet<Currency> Currencies { get; set; }
        DbSet<DbStat> DbStats { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<FailedLogin> FailedLogins { get; set; }
        DbSet<FiscalYear> FiscalYears { get; set; }
        DbSet<Flag> Flags { get; set; }
        DbSet<FlagType> FlagTypes { get; set; }
        DbSet<Frequency> Frequencies { get; set; }
        DbSet<FrequencySetup> FrequencySetups { get; set; }
        DbSet<History> Histories { get; set; }
        DbSet<ItemCostPrice> ItemCostPrices { get; set; }
        DbSet<ItemGroup> ItemGroups { get; set; }
        DbSet<ItemOpeningInventory> ItemOpeningInventories { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<ItemSellingPrice> ItemSellingPrices { get; set; }
        DbSet<LeadSource> LeadSources { get; set; }
        DbSet<LeadStatus> LeadStatuses { get; set; }
        DbSet<LockOut> LockOuts { get; set; }
        DbSet<Login> Logins { get; set; }
        DbSet<MenuAccess> MenuAccesses { get; set; }
        DbSet<MenuLocale> MenuLocales { get; set; }
        DbSet<MenuPolicy> MenuPolicies { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<NonGlStockDetail> NonGlStockDetails { get; set; }
        DbSet<NonGlStockMasterRelation> NonGlStockMasterRelations { get; set; }
        DbSet<NonGlStockMaster> NonGlStockMasters { get; set; }
        DbSet<Office> Offices { get; set; }
        DbSet<OfficeView> OfficeViews { get; set; }
        DbSet<OpportunityStage> OpportunityStages { get; set; }
        DbSet<Party> Parties { get; set; }
        DbSet<PartyType> PartyTypes { get; set; }
        DbSet<PriceType> PriceTypes { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<RoleView> RoleViews { get; set; }
        DbSet<Shipper> Shippers { get; set; }
        DbSet<ShippingAddress> ShippingAddresses { get; set; }
        DbSet<StockDetail> StockDetails { get; set; }
        DbSet<StockMasterNonGlRelation> StockMasterNonGlRelations { get; set; }
        DbSet<StockMaster> StockMasters { get; set; }
        DbSet<StorePolicy> StorePolicies { get; set; }
        DbSet<StorePolicyDetail> StorePolicyDetails { get; set; }
        DbSet<Store> Stores { get; set; }
        DbSet<StoreType> StoreTypes { get; set; }
        DbSet<StoreView> StoreViews { get; set; }
        DbSet<SwitchCategory> SwitchCategories { get; set; }
        DbSet<Taxis> Taxes { get; set; }
        DbSet<TaxType> TaxTypes { get; set; }
        DbSet<TransactionDetail> TransactionDetails { get; set; }
        DbSet<TransactionMaster> TransactionMasters { get; set; }
        DbSet<TrialBalanceView> TrialBalanceViews { get; set; }
        DbSet<Unit> Units { get; set; }
        DbSet<UnitView> UnitViews { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<VerificationStatus> VerificationStatuses { get; set; }
        DbSet<VoucherVerificationPolicy> VoucherVerificationPolicies { get; set; }
        DbSet<VoucherVerificationPolicyView> VoucherVerificationPolicyViews { get; set; }
        DbSet<WorkCenter> WorkCenters { get; set; }
        DbSet<WorkCenterView> WorkCenterViews { get; set; }

        Task<int> ExecuteSqlRawAsync(MixerpContext context, string sql, CancellationToken cancellationToken);

        Task<int> ExecuteSqlRawAsync(MixerpContext context, string sql, List<NpgsqlParameter> parameters);
    }
}