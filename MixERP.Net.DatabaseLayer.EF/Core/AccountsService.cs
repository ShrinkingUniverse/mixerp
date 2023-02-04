using MixERP.Net.DBFactory.EF.Context;

namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public class AccountsService : IAccountsService
    {
        private readonly IMixerpContext _mixerpContext;
        public AccountsService(IMixerpContext mixerpContext)
        {
            _mixerpContext = mixerpContext;
        }
        public bool IsCashAccount(int accountId)
        {
                return _mixerpContext.Accounts.Where(a => a.AccountId == accountId).FirstOrDefault() != null;
        }

        public bool IsCashAccount(string accountCode)
        {
                var accounts = _mixerpContext.Accounts.Where(a => String.Compare(a.AccountCode, accountCode) == 0).FirstOrDefault();
                return accounts != null;
        }
    }
}
