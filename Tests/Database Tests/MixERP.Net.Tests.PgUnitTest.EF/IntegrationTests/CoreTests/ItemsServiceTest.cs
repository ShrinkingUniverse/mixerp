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
        private Mock<IProcedureExecutor> _procedureExecutorMock;
        [SetUp]
        public void Setup()
        {
            _mixerpContextMock = new MixerpContext();
            _procedureExecutorMock = new Mock<IProcedureExecutor>();
            _itemsService = new ItemsService(_mixerpContextMock, _procedureExecutorMock.Object);
        }

        [Test]
        public void ItemExistsByCode_NotExistingCodereturnFalse()
        {
            string itemCode = "1";
            var result = _itemsService.ItemExistsByCode(itemCode);
            Assert.IsFalse(result);
        }
    }
}
