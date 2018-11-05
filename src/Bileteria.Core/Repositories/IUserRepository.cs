using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bileteria.Core.Domain;

namespace Bileteria.Core.Repositories
{
    public interface IUserRepository
    {
         Task<User> GetAsync(Guid id);
         Task<User> GetAsync(string email);
         Task AddAsync(User user);
         Task UpdateAsync(User user);
         Task DeleteAsync(User user);
    }
}