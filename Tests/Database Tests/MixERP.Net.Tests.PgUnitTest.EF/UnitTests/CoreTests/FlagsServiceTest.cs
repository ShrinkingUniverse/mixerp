using MixERP.Net.DatabaseLayer.EF.Core;
using MixERP.Net.DatabaseLayer.EF.Core.Interfaces;
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
        private Mock<IProcedureExecutor> _procedureExecutorMock;

        [SetUp]
        public void Setup()
        {
            _mixerpContextMock = new Mock<MixerpContext>();
            _procedureExecutorMock = new Mock<IProcedureExecutor>();
            _flagsService = new FlagsService(_mixerpContextMock.Object, _procedureExecutorMock.Object);
        }

        [Test]
        public void CreateFlag_WrongUserId_CreateFlagWasntСalled()
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
            List<NpgsqlParameter> parms = new List<NpgsqlParameter> { };
            var result = _flagsService.CreateFlag(userId, flagTypeId, "Test", "Test", ids).Result;
            _procedureExecutorMock.Verify(s => s.ExecuteSqlRawAsync(_mixerpContextMock.Object, sql, parms).Result, Times.Never());
        }

        [Test]
        public void CreateFlag_NullResourceName_CreateFlagWasntСalled()
        {
            Collection<int> ids = new Collection<int>()
            {
                2,
                3,
                5
            };
            const string sql = "SELECT core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId)";
            int userId = 30;
            int flagTypeId = 6;
            List<NpgsqlParameter> parms = new List<NpgsqlParameter> { };
            var result = _flagsService.CreateFlag(userId, flagTypeId, "", "Test", ids).Result;
            _procedureExecutorMock.Verify(s => s.ExecuteSqlRawAsync(_mixerpContextMock.Object, sql, parms).Result, Times.Never());
        }

        [Test]
        public void CreateFlag_ParamsAreOk_CreateFlagWasntСalled()
        {
            Collection<int> ids = new Collection<int>()
            {
                2,
                3,
                5
            };
            const string sql = "SELECT core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId)";
            int userId = 30;
            int flagTypeId = 6;

            List<NpgsqlParameter> parms = new List<NpgsqlParameter> {
                    new NpgsqlParameter { ParameterName = "@UserId", Value = userId },
                    new NpgsqlParameter { ParameterName = "@FlagTypeId", Value = flagTypeId },
                    new NpgsqlParameter { ParameterName = "@Resource", Value = "Test" },
                    new NpgsqlParameter { ParameterName = "@ResourceKey", Value = "Test" },
                    new NpgsqlParameter { ParameterName = "@ResourceId", Value = 2 }};

            _procedureExecutorMock.Setup(s => s.ExecuteSqlRawAsync(_mixerpContextMock.Object, sql, parms).Result).Returns(3);
            var result = _flagsService.CreateFlag(userId, flagTypeId, "Test", "Test", ids).Result;
            _procedureExecutorMock.Verify(s => s.ExecuteSqlRawAsync(_mixerpContextMock.Object, sql, parms), Times.Once());
        }
    }
}