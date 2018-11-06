using System;
using System.Threading.Tasks;
using Bileteria.Core.Domain;
using Bileteria.Core.Repositories;
using Bileteria.Infrastructure.Repositories;
using Xunit;

namespace Bileteria.Tests.Repositories
{
    public class UserRepositoryTests
    {
        [Fact]
        public async Task when_adding_new_user_it_should_be_added_correctly_to_the_list()
        {
            var user = new User(Guid.NewGuid(), "user", "test", "test@test.com", "secret");
            IUserRepository repository = new UserRepository();

            await repository.AddAsync(user);

            var existingUser = await repository.GetAsync(user.Id);
            Assert.Equal(user, existingUser);
        }
    }
}