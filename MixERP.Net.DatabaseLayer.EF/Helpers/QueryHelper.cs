using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
