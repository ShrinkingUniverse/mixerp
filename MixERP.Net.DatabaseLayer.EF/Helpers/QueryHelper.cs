using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MixERP.Net.DatabaseLayer.EF.Helpers
{
    public static class QueryHelper
    {
        public static IQueryable<T> Include<T, TResult>(this IQueryable<T> source, Expression<Func<T, TResult>> navigationPropertyPath) where T : class
        {
            return EntityFrameworkQueryableExtensions.Include(source, navigationPropertyPath);
        }

        public static Task<T?> FirstOrDefaultAsync<T>(this IQueryable<T> source)
        {
            return EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(source);
        }

        public static Task<List<T>> ToListAsync<T>(this IQueryable<T> source)
        {
            return EntityFrameworkQueryableExtensions.ToListAsync(source);
        }
    }
}
