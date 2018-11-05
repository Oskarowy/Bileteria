using System;
using System.Threading.Tasks;
using Bileteria.Infrastructure.DTO;

namespace Bileteria.Infrastructure.Services
{
    public interface IUserService
    {
        Task RegisterAsync(Guid userId, string email, string name, string password, string role = "user");
        Task<TokenDto> LoginAsync(string email, string password);
    }
}