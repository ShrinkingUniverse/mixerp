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
    public class FlagsServiceIntegrationTest
    {
        private IFlagsService _flagsService;
        private MixerpContext _mixerpContextMock;
        private ProcedureExecutor _procedureExecutor;

        [SetUp]
        public void Setup()
        {
            _mixerpContextMock = new MixerpContext();
            _procedureExecutor = new ProcedureExecutor();
            _flagsService = new FlagsService(_mixerpContextMock, _procedureExecutor);
        }

        [Test]
        public void CreateFlag_ParamsAreOk_CreateFlagWasntСalled()
        {
            var removedItems = _flagsService.RemoveFlagsFromDb().Result;
            Collection<int> ids = new Collection<int>()
            {
                2
            };
           int userId = 1;
            int flagTypeId = 3;

            List<NpgsqlParameter> parms = new List<NpgsqlParameter> {
                    new NpgsqlParameter { ParameterName = "@UserId", Value = userId },
                    new NpgsqlParameter { ParameterName = "@FlagTypeId", Value = flagTypeId },
                    new NpgsqlParameter { ParameterName = "@Resource", Value = "Test" },
                    new NpgsqlParameter { ParameterName = "@ResourceKey", Value = "Test" },
                    new NpgsqlParameter { ParameterName = "@ResourceId", Value = 2 }};

            var result = _flagsService.CreateFlag(userId, flagTypeId, "Test", "Test", ids).Result;
            Assert.AreEqual(1, result);
        }
    }
}