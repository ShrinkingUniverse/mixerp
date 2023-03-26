using MixERP.Net.DatabaseLayer.Core;
using MixERP.Net.DBFactory.EF.Context;
using Moq;
using NUnit.Framework;

namespace MixERP.Net.Tests.PgTest.EF.IntegrationTests.CoreTests
{
    [TestFixture]
    public class ItemsServiceTest
    {
        private ItemsService _itemsService;
        private MixerpContext _mixerpContextMock;
        private ProcedureExecutor _procedureExecutorMock;
        [SetUp]
        public void Setup()
        {
            _mixerpContextMock = new MixerpContext();
            _procedureExecutorMock = new ProcedureExecutor();
            _itemsService = new ItemsService(_mixerpContextMock, _procedureExecutorMock);
        }

        [Test]
        public void ItemExistsByCode_NotExistingCodeReturnFalse()
        {
            string itemCode = "-1";
            var result = _itemsService.ItemExistsByCode(itemCode);
            Assert.IsFalse(result);
        }

        [Test]
        public void ItemExistsByCode_ExistingCodeReturnTrue()
        {
            string itemCode = "TestItem02";
            var result = _itemsService.ItemExistsByCode(itemCode);
            Assert.IsTrue(result);
        }

        [Test]
        public void GetItemSellingPrice_ItemCode_Success()
        {
            string itemCode = "TestItem02";
            string partyCode = "TETTE-0002";
            var result = _itemsService.GetItemSellingPrice(itemCode, partyCode, 1, 6);

        }

        [Test]
        public void GetItemCostPrice_ItemCode_Success()
        {
            string itemCode = "TestItem02";
            string partyCode = "TETTE-0002";
            var result = _itemsService.GetItemCostPrice(itemCode, partyCode, 6);

        }

        //GetItemCostPrice
    }
}
