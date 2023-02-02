using Microsoft.EntityFrameworkCore;
using MixERP.Net.DatabaseLayer.EF.Core;
using MixERP.Net.DBFactory.EF.Context;
using Moq;
using Npgsql;
using NUnit.Framework;
using System.Collections.ObjectModel;

namespace MixERP.Net.Tests.PgUnitTest.EF.CoreTests
{
    [TestFixture]
    public class FlagsServiceTest
    {
        private IFlagsService _flagsService;
        private Mock<MixerpContext> _mixerpContextMock;

        [SetUp]
        public void Setup()
        {
            _mixerpContextMock = new Mock<MixerpContext>();
            _flagsService = new FlagsService(_mixerpContextMock.Object);
        }

        [Test]
        public void CreateFlag_WrongUserId_Returned()
        {
            Collection<int> ids = new Collection<int>()
            {
                2,
                3,
                5
            };
            const string sql = "SELECT core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId)";
            int userId = -30;
            int flagTypeId = 6;
            List<NpgsqlParameter> parms = new List<NpgsqlParameter>{ };
            _flagsService.CreateFlag(userId, flagTypeId, "", "", ids);
            _mixerpContextMock.Setup(_ => _.ExecuteSqlRawAsync(_mixerpContextMock.Object, sql).Result).Returns(2);
            _mixerpContextMock.Verify(s => s.ExecuteSqlRawAsync(_mixerpContextMock.Object, sql).Result, Times.Never());
        }
    }
}