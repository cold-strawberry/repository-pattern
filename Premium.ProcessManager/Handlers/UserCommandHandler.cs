using Premium.Commons.Handlers;
using Premium.ProcessManager.Messages.Commands;
using Premium.ProcessManager.Repositories;
using System;
using System.Threading.Tasks;

namespace Premium.ProcessManager.Handlers
{
    public class UserCommandHandler : ICommandHandler<UserCommand>
    {
        private readonly IConnectionsRepository _connectionRepository;
        private readonly IPlatformsRepository _platformRepository;

        public UserCommandHandler(IConnectionsRepository connectionRepository, IPlatformsRepository platformRepository)
        {
            _connectionRepository = connectionRepository;
            _platformRepository = platformRepository;

        }
        public async Task HandleAsync(UserCommand command)
        {
            await  _connectionRepository.GetConnectionAsync(3, "REMOTE");
        }
    }
}
