using Premium.DatabaseAdapters.postgresql.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.ProcessManager.Repositories
{
    public interface IPlatformsRepository : IRepository
    {
        Task<Platform> GetPlatformByIdAsync(int platformId);
        Task<IEnumerable<Platform>> GetAllPlatforms();

    }
}
