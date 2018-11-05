using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bileteria.Core.Domain;
using Bileteria.Infrastructure.DTO;

namespace Bileteria.Infrastructure.Services
{
    public interface IEventService
    {
        Task<EventDto> GetAsync(Guid id);
        Task<EventDto> GetAsync(string name);
        Task<IEnumerable<EventDto>> BrowseAsync(string name = "");
        Task CreateAsync(Guid id, string name, string description, DateTime startDate, DateTime endDate);
        Task AddTicketsAsync(Guid eventId, int amount, decimal price);
        Task UpdateAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);

    }
}