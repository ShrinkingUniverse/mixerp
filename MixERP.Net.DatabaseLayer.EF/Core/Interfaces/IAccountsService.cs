namespace MixERP.Net.DatabaseLayer.EF.Core.Interfaces
{
    public interface IAccountsService
    {
        bool IsCashAccount(int accountId);
        bool IsCashAccount(string accountCode);
    }
}