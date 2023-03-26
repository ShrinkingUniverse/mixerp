using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace MixERP.Net.DBFactory.EF.Context
{
    public class ProcedureExecutor : IProcedureExecutor
    {
        public virtual async Task<int> ExecuteSqlRawAsync(MixerpContext context, string sql, CancellationToken cancellationToken)
        {
            return await context.Database.ExecuteSqlRawAsync(sql, cancellationToken);
        }

        public virtual async Task<int> ExecuteSqlRawAsync(MixerpContext context, string sql, 
            List<NpgsqlParameter> parameters)
        {
            return await context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public virtual IQueryable<TResult> SqlQueryRaw<TResult>(MixerpContext context,
        string sql, List<NpgsqlParameter> parameters)
        {
            return context.Database.SqlQueryRaw<TResult>(sql, parameters);
        }

        public virtual IQueryable<TResult> SqlQuery<TResult>(MixerpContext context,
        FormattableString sql)
        {
            return context.Database.SqlQuery<TResult>(sql);
        }

        public virtual TResult QueryValue<TResult>(MixerpContext context,
        string sql, List<NpgsqlParameter> parameters)
        {
            return context.Database.SqlQueryRaw<TResult>(sql, parameters).FirstOrDefault();
        }
    }
}
