using System.Threading.Tasks;

namespace Premium.Commons
{
    public interface IInitializer
    {
        Task InitializeAsync();
    }
}