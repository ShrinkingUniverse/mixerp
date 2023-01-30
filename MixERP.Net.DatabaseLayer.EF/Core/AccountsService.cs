using MixERP.Net.DBFactory.EF.Context;

namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public class AccountsService : IAccountsService
    {
        public bool IsCashAccount(int accountId)
        {
            using (var db = new MixerpContext())
            {
                var accounts = db.Accounts.Where(a => a.AccountId == accountId).FirstOrDefault();
                return accounts != null;
            }
        }

        public bool IsCashAccount(string accountCode)
        {
            using (var db = new MixerpContext())
            {
                var accounts = db.Accounts.Where(a => String.Compare(a.AccountCode, accountCode) == 0).FirstOrDefault();
                return accounts != null;
            }
        }
    }
}
