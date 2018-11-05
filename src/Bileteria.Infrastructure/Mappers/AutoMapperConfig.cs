using System.Linq;
using AutoMapper;
using Bileteria.Core.Domain;
using Bileteria.Infrastructure.DTO;

namespace Bileteria.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Event, EventDto>()
                    .ForMember(x => x.TicketsCount, m => m.MapFrom(p => p.Tickets.Count()));
                cfg.CreateMap<Event, EventDetailsDto>();
                cfg.CreateMap<Ticket, TicketDto>();
            })
            .CreateMapper();
    }
}