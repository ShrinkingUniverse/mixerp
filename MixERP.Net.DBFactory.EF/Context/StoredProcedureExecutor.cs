using Microsoft.EntityFrameworkCore;

namespace MixERP.Net.DBFactory.EF.Context
{
    public class StoredProcedureExecutor : IStoredProcedureExecutor
    {
        private DbContext _dbContext { get; }
        public StoredProcedureExecutor(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<int> ExecuteSqlRawAsync(string sql, params object[] parameters)
        {
            return _dbContext.Database.ExecuteSqlRawAsync(sql, parameters);
        }
    }
}
