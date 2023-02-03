using MixERP.Net.DBFactory.EF.Context;
using Npgsql;
using System.Collections.ObjectModel;

namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public class FlagsService : IFlagsService
    {
        private readonly IMixerpContext _mixerpContext;
        public FlagsService(IMixerpContext mixerpContext)
        {
            _mixerpContext = mixerpContext; 
        }
        public void CreateFlag(int userId, int flagTypeId, string resourceName, string resourceKey,
            Collection<int> resourceIds)
        {

            if (userId <= 0)
            {
                return;
            }

            if (flagTypeId <= 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(resourceName))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(resourceKey))
            {
                return;
            }

            if (resourceIds == null)
            {
                return;
            }
            const string sql = "SELECT core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId);";
            foreach (int resourceId in resourceIds)
            {
                List<NpgsqlParameter> parms = new List<NpgsqlParameter>
                { 
                    // Create parameters    
                    new NpgsqlParameter { ParameterName = "@UserId", Value = userId },
                    new NpgsqlParameter { ParameterName = "@FlagTypeId", Value = flagTypeId },
                    new NpgsqlParameter { ParameterName = "@Resource", Value = resourceName },
                    new NpgsqlParameter { ParameterName = "@ResourceKey", Value = resourceKey },
                    new NpgsqlParameter { ParameterName = "@ResourceId", Value = resourceId }

                };
                    var accounts = _mixerpContext.ExecuteSqlRawAsync((MixerpContext)_mixerpContext, sql, parms);
            }
        }
    }
}
