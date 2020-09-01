using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Premium.Commons.Types;

namespace Premium.Commons.PgSql
{
    public interface IPgSqlRepository<TEntity> where TEntity : class
    {
         Task<TEntity> FindFirstAsync(Expression<Func<TEntity, bool>> predicate);
         Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
         Task<PagedResult<TEntity>> BrowseAsync<TQuery>(Expression<Func<TEntity, bool>> predicate, TQuery query) where TQuery : PagedQueryBase;
         Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate);

    }
}