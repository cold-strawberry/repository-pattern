using System.Threading.Tasks;
using Premium.Commons.Messages;

namespace Premium.Common.Dispatchers
{
    public interface ICommandDispatcher
    {
         Task SendAsync<T>(T command) where T : ICommand;
    }
}