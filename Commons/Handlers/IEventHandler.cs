using Premium.Commons.Messages;
using System.Threading.Tasks;

namespace Premium.Commons.Handlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}