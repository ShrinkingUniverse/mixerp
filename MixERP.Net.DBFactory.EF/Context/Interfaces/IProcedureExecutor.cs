using Npgsql;

namespace MixERP.Net.DBFactory.EF.Context
{
    public interface IProcedureExecutor
    {
        Task<int> ExecuteSqlRawAsync(MixerpContext context, string sql, CancellationToken cancellationToken);
        Task<int> ExecuteSqlRawAsync(MixerpContext context, string sql, List<NpgsqlParameter> parameters);
        IQueryable<TResult> SqlQueryRaw<TResult>(MixerpContext context,
        string sql, List<NpgsqlParameter> parameters);
        IQueryable<TResult> SqlQuery<TResult>(MixerpContext context, FormattableString sql);

        TResult QueryValue<TResult>(MixerpContext context,
        string sql, List<NpgsqlParameter> parameters);
    }
}