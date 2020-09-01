using Premium.Commons.Messages;
using System.Threading.Tasks;

namespace Premium.Commons.Handlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }
}