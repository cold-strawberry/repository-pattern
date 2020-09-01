using System.Threading.Tasks;
using Premium.Commons.Types;

namespace Premium.Common.Dispatchers
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}