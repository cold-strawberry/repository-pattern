using Premium.Commons.PgSql;
using Premium.DatabaseAdapters.postgresql.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.ProcessManager.Repositories
{
    public class ConnectionsRepository : IConnectionsRepository
    {
        private readonly IPgSqlRepository<Connection> _repository;

        public ConnectionsRepository(IPgSqlRepository<Connection> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Connection>> GetAllConnectionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Connection> GetConnectionAsync(int id, string location)
            => await _repository.FindFirstAsync(e => e.Id == id && e.Location == location);

    }
}
