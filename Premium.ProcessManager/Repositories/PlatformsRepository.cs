using Premium.Commons.PgSql;
using Premium.DatabaseAdapters.postgresql.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.ProcessManager.Repositories
{
    public class PlatformsRepository : IPlatformsRepository
    {
        private readonly IPgSqlRepository<Platform> _repository;

        public PlatformsRepository(IPgSqlRepository<Platform> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Platform>> GetAllPlatforms()
        {
            throw new NotImplementedException();
        }

        public async Task<Platform> GetPlatformByIdAsync(int id)
            => await _repository.FindFirstAsync(e => e.Id == id );

   
    }



}
