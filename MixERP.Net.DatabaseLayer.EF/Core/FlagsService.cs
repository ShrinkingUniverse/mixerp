using MixERP.Net.DBFactory.EF.Context;
using Npgsql;
using System.Collections.ObjectModel;

namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public class FlagsService : IFlagsService
    {
        private readonly IMixerpContext _mixerpContext;
        private readonly IProcedureExecutor _procedureExecutor;
        public FlagsService(IMixerpContext mixerpContext, IProcedureExecutor procedureExecutor)
        {
            _mixerpContext = mixerpContext; 
            _procedureExecutor = procedureExecutor; 
        }
        public async Task<int> CreateFlag(int userId, int flagTypeId, string resourceName, string resourceKey,
            Collection<int> resourceIds)
        {
            int rowCount = 0;

            if (userId <= 0)
            {
                return 0;
            }

            if (flagTypeId <= 0)
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(resourceName))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(resourceKey))
            {
                return 0;
            }

            if (resourceIds == null)
            {
                return 0;
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
                rowCount = rowCount + await _procedureExecutor.ExecuteSqlRawAsync((MixerpContext)_mixerpContext, sql, parms);
            }
            return rowCount;
        }
    }
}
