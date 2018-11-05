using System.Threading.Tasks;
using Bileteria.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bileteria.Api.Controllers
{
    [Route("[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventService _eventService;
        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string name)
        {
            var events = await _eventService.BrowseAsync(name);

            return Json(events);
        }
    }
}