namespace MixERP.Net.DatabaseLayer.Core
{
    public interface IItemsService
    {
        decimal CountItemInStock(string itemCode, int unitId, int storeId);
        decimal CountItemInStock(string itemCode, string unitName, int storeId);
        string GetItemCodeByItemId(int itemId);
        decimal GetItemCostPrice(string itemCode, string partyCode, int unitId);
        decimal GetItemSellingPrice(string itemCode, string partyCode, int priceTypeId, int unitId);
        decimal GetTaxRate(string itemCode);
        bool IsStockItem(string itemCode);
        bool ItemExistsByCode(string itemCode);
    }
}