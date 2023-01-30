using MixERP.Net.DatabaseLayer.EF.Core;
using NUnit.Framework;

namespace MixERP.Net.Tests.PgUnitTest.EF.CoreTests
{
    [TestFixture]
    public class AccountServiceTest
    {
        private IAccountsService _accountsService;
        [SetUp]
        public void Setup()
        {
            _accountsService = new AccountsService();
        }

        [Test]
        public void IsCashAccount_ExistingId_Success()
        {
            int accountId = 30;
            Assert.That(_accountsService.IsCashAccount(accountId), Is.EqualTo(true));
        }

        [Test]
        public void IsCashAccount_ExistingCode_Success()
        {
            string accountCode = "12001";
            Assert.That(_accountsService.IsCashAccount(accountCode), Is.EqualTo(true));
        }
        [Test]
        public void IsCashAccount_WrongId_Success()
        {
            int accountId = -15;
            Assert.That(_accountsService.IsCashAccount(accountId), Is.EqualTo(false));
        }

        [Test]
        public void IsCashAccount_WrongCode_Success()
        {
            string accountCode = "00000";
            Assert.That(_accountsService.IsCashAccount(accountCode), Is.EqualTo(false));
        }
    }
}