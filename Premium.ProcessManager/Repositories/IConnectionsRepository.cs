using Premium.DatabaseAdapters.postgresql.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.ProcessManager.Repositories
{
    public interface IConnectionsRepository : IRepository
    {
         Task<Connection> GetConnectionAsync(int id, string location);
         Task<IEnumerable<Connection>> GetAllConnectionAsync(int id);

    }
}
