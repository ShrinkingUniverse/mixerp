namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public interface IAccountsService
    {
        bool IsCashAccount(int accountId);
        bool IsCashAccount(string accountCode);
    }
}