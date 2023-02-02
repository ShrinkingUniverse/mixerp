namespace MixERP.Net.DBFactory.EF.Context
{
    public interface IStoredProcedureExecutor
    {
        Task<int> ExecuteSqlRawAsync(string sql, params object[] parameters);
    }
}