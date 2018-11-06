using System.Threading.Tasks;

namespace Bileteria.Infrastructure.Services
{
    public interface IDataInitializer
    {
        Task SeedAsync();
    }
}