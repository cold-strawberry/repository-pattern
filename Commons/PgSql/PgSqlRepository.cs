using Premium.Commons.Types;
using Microsoft.EntityFrameworkCore;
using Premium.DatabaseAdapters.postgresql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Premium.DatabaseAdapters.PgSql;

namespace Premium.Commons.PgSql
{
    public class PgSqlRepository<TEntity> : IPgSqlRepository<TEntity> where TEntity : class
    {
        private readonly PremiumDbContext context;
        private DbSet<TEntity> dbSet;


        public PgSqlRepository(PremiumDbContext dbContext)
        {
            this.context = dbContext;
            this.dbSet = context.Set<TEntity>();
        }

        public Task<PagedResult<TEntity>> BrowseAsync<TQuery>(Expression<Func<TEntity, bool>> predicate, TQuery query) where TQuery : PagedQueryBase
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = this.dbSet;
            query = query.Where(predicate);
            return (IEnumerable<TEntity>)query.ToListAsync();
        }

        public async Task<TEntity> FindFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = this.dbSet;
            query = query.Where(predicate);
            return (TEntity)query.Take(1);

        }
    }
}