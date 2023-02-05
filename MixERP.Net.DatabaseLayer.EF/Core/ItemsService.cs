using Microsoft.EntityFrameworkCore;
using MixERP.Net.DatabaseLayer.EF.Core.Interfaces;
using MixERP.Net.DBFactory.EF.Context;
using Npgsql;

namespace MixERP.Net.DatabaseLayer.Core
{
    public class ItemsService : IItemsService
    {
        private readonly IMixerpContext _mixerpContext;
        private readonly IProcedureExecutor _procedureExecutor;
        public ItemsService(IMixerpContext mixerpContext, IProcedureExecutor procedureExecutor)
        {
            _mixerpContext = mixerpContext;
            _procedureExecutor = procedureExecutor;
        }
        public bool ItemExistsByCode(string itemCode)
        {
            return _mixerpContext.Items.Where(x => x.ItemCode == itemCode).FirstOrDefault() != null;
        }

        public decimal GetItemSellingPrice(string itemCode, string partyCode, int priceTypeId, 
            int unitId)
        {
            int itemId = _mixerpContext.Items.Where(x => x.ItemCode == itemCode)
                                             .Select(x => x.ItemId)
                                             .FirstOrDefault();

            int partyTypeId = _mixerpContext.Parties.Where(x => x.PartyCode == partyCode)
                                                    .Select(x => x.PartyTypeId)
                                                    .FirstOrDefault();
            decimal result = 0;

            string sql = "SELECT core.get_item_selling_price(@ItemId, @PartyTypeId, @PriceTypeId, @UnitId);";

            List<NpgsqlParameter> parms = new List<NpgsqlParameter>
                { 
                    // Create parameters    
                    new NpgsqlParameter { ParameterName = "@ItemId", Value = itemId },
                    new NpgsqlParameter { ParameterName = "@PartyTypeId", Value = partyTypeId },
                    new NpgsqlParameter { ParameterName = "@PriceTypeId", Value = priceTypeId },
                    new NpgsqlParameter { ParameterName = "@UnitId", Value = unitId },
                };

            result = _procedureExecutor.SqlQueryRaw<decimal>((MixerpContext)_mixerpContext, sql, parms)
                                       .AsEnumerable().FirstOrDefault();

            return result;

        }

        public decimal GetItemCostPrice(string itemCode, string partyCode, int unitId)
        {
            int itemId = _mixerpContext.Items.Where(x => x.ItemCode == itemCode)
                                             .Select(x => x.ItemId)
                                             .FirstOrDefault();

            int partyTypeId = _mixerpContext.Parties.Where(x => x.PartyCode == partyCode)
                                                    .Select(x => x.PartyTypeId)
                                                    .FirstOrDefault();
            decimal result = 0;
            const string sql = "SELECT core.get_item_cost_price(@ItemId, @PartyTypeId, @UnitId);";

            List<NpgsqlParameter> parms = new List<NpgsqlParameter>
            {
                new NpgsqlParameter { ParameterName = "@ItemId", Value = itemId },
                new NpgsqlParameter { ParameterName = "@PartyTypeId", Value = partyTypeId },
                new NpgsqlParameter { ParameterName = "@UnitId", Value = unitId },
            };

            result = _procedureExecutor.SqlQueryRaw<decimal>((MixerpContext)_mixerpContext, sql, parms)
                                       .AsEnumerable().FirstOrDefault();

            return result;
        }

        public decimal GetTaxRate(string itemCode)
        {
            return _mixerpContext.Items.Where(x => x.ItemCode == itemCode).Include(x => x.Tax)
                                                .Select(c => c.Tax.Rate).FirstOrDefault();
        }

        public decimal CountItemInStock(string itemCode, int unitId, int storeId)
        {
            int itemId = _mixerpContext.Items.Where(x => x.ItemCode == itemCode)
                                             .Select(x => x.ItemId)
                                             .FirstOrDefault();
            decimal result = 0;
            const string sql = "SELECT core.count_item_in_stock(@ItemId, @UnitId, @StoreId);";

            List<NpgsqlParameter> parms = new List<NpgsqlParameter>
            {
                new NpgsqlParameter { ParameterName = "@ItemId", Value = itemId },
                new NpgsqlParameter { ParameterName = "@UnitId", Value = unitId },
                new NpgsqlParameter { ParameterName = "@StoreId", Value = storeId },
            };
            result = _procedureExecutor.SqlQueryRaw<decimal>((MixerpContext)_mixerpContext, sql, parms)
                                      .AsEnumerable().FirstOrDefault();

            return result;
        }

        public decimal CountItemInStock(string itemCode, string unitName, int storeId)
        {
            int itemId = _mixerpContext.Items.Where(x => x.ItemCode == itemCode)
                                             .Select(x => x.ItemId)
                                             .FirstOrDefault();

            int unitId = _mixerpContext.Units.Where(u => u.UnitName == unitName)
                                             .Select(u => u.UnitId).FirstOrDefault();

            decimal result = 0;
            const string sql = "SELECT core.count_item_in_stock(@ItemId, @UnitId, @StoreId);";

            List<NpgsqlParameter> parms = new List<NpgsqlParameter>
            {
                new NpgsqlParameter { ParameterName = "@ItemId", Value = itemId },
                new NpgsqlParameter { ParameterName = "@UnitId", Value = unitId },
                new NpgsqlParameter { ParameterName = "@StoreId", Value = storeId },
            };
            result = _procedureExecutor.SqlQueryRaw<decimal>((MixerpContext)_mixerpContext, sql, parms)
                                      .AsEnumerable().FirstOrDefault();

            return result;
        }

        public bool IsStockItem(string itemCode)
        {
            return _mixerpContext.Items.Where(x => x.ItemCode == itemCode && x.MaintainStock == true) != null;
        }


        public string GetItemCodeByItemId(int itemId)
        {
            return _mixerpContext.Items.Where(i => i.ItemId == itemId).Select(i => i.ItemCode).FirstOrDefault() ?? "";
        }
    }
}
