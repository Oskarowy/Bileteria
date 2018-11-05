using System;
using Bileteria.Infrastructure.DTO;

namespace Bileteria.Infrastructure.Services
{
    public interface IJwtHandler
    {
        JwtDto CreateToken(Guid userId, string role);
    }
}