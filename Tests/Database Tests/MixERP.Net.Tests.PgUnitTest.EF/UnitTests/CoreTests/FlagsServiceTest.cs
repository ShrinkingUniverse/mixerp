using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
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
            _flagsService = new FlagsService();
            _mixerpContextMock = new Mock<MixerpContext>(); 
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
            const string sql = "SELECT core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId);"
            int userId = -30;
            int flagTypeId = 6;
            List<NpgsqlParameter> parms = new List<NpgsqlParameter>{ };
            _flagsService.CreateFlag(userId, flagTypeId, "", "", ids);
            var result = await _mixerpContextMock.Verify(s => s.Database.ExecuteSqlRawAsync(sql), )
            _mixerpContextMock.Verify(s => s.Database.ExecuteSqlRawAsync(sql, parms).Result, Times.Never());
        }
    }
}