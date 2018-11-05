using System.Collections.Generic;

namespace Bileteria.Infrastructure.DTO
{
    public class EventDetailsDto : EventDto
    {
        public IEnumerable<TicketDto> Tickets { get; set; }
    }
}