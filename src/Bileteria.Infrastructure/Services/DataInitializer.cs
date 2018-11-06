using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bileteria.Infrastructure.Services
{
    public class DataInitializer : IDataInitializer
    {
        private readonly IUserService _userService;
        private readonly IEventService _eventService;
        public DataInitializer(IUserService userService, IEventService eventService)
        {
            _userService = userService;
            _eventService = eventService;
        }
        public async Task SeedAsync()
        {
            var tasks = new List<Task>();
            tasks.Add(_userService.RegisterAsync(Guid.NewGuid(), "user@email.com", "default user",
                "secret"));
            tasks.Add(_userService.RegisterAsync(Guid.NewGuid(), "admin@mail.com", "admin", "secret", "admin"));
            for(var i = 1; i <= 10; i++)
            {
                var eventId = Guid.NewGuid();
                var name = $"Event {i}";
                var description = $"{name} description";
                var startDate = DateTime.UtcNow.AddHours(3);
                var endDate = startDate.AddHours(2);
                tasks.Add(_eventService.CreateAsync(eventId, name, description, startDate, endDate));
                tasks.Add(_eventService.AddTicketsAsync(eventId, 1000, 100));
            }
            await Task.WhenAll(tasks);
        }
    }
}