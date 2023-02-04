using Microsoft.EntityFrameworkCore;
using MixERP.Net.DBFactory.EF.Context;
using Npgsql;

namespace MixERP.Net.DatabaseLayer.Core
{
    public class ItemsService
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

        public decimal GetItemSellingPrice(string itemCode, string partyCode, int priceTypeId, int unitId)
        {
            int itemId = _mixerpContext.Items.Where(x => x.ItemCode == itemCode)
                                             .Select(x => x.ItemId)
                                             .FirstOrDefault();

            int partyTypeId = _mixerpContext.Parties.Where(x => x.PartyCode == partyCode)
                                                    .Select(x => x.PartyTypeId)
                                                    .FirstOrDefault();
            decimal result = 0;

            string sql = "SELECT core.get_item_selling_price(@ItemId, @PartyTypeId, @PriceTypeId, @UnitId);";

            List <NpgsqlParameter> parms = new List<NpgsqlParameter>
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
            int itemTaxId = _mixerpContext.Items.Where(x => x.ItemCode == itemCode).Include(x => x.
                                             .Select(x => x.TaxId)
                                             .FirstOrDefault();

            const string sql = "SELECT core.get_item_tax_rate(core.get_item_id_by_item_code(@ItemCode));";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);
                return Conversion.TryCastDecimal(DbOperations.GetScalarValue(command));
            }
        }

        public static decimal CountItemInStock(string itemCode, int unitId, int storeId)
        {
            const string sql = "SELECT core.count_item_in_stock(core.get_item_id_by_item_code(@ItemCode), @UnitId, @StoreId);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);
                command.Parameters.AddWithValue("@UnitId", unitId);
                command.Parameters.AddWithValue("@StoreId", storeId);
                return Conversion.TryCastDecimal(DbOperations.GetScalarValue(command));
            }
        }

        public static decimal CountItemInStock(string itemCode, string unitName, int storeId)
        {
            const string sql = "SELECT core.count_item_in_stock(core.get_item_id_by_item_code(@ItemCode), core.get_unit_id_by_unit_name(@UnitName), @StoreId);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);
                command.Parameters.AddWithValue("@UnitName", unitName);
                command.Parameters.AddWithValue("@StoreId", storeId);
                return Conversion.TryCastDecimal(DbOperations.GetScalarValue(command));
            }
        }

        public static bool IsStockItem(string itemCode)
        {
            const string sql = "SELECT 1 FROM core.items WHERE item_code=@ItemCode AND maintain_stock=true;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);

                return DbOperations.GetDataTable(command).Rows.Count.Equals(1);
            }
        }


        public static string GetItemCodeByItemId(int itemId)
        {
            const string sql = "SELECT item_code FROM core.items WHERE item_id=@ItemId;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@ItemId", itemId);

                return Conversion.TryCastString(DbOperations.GetScalarValue(command));
            }
        }
    }
}
