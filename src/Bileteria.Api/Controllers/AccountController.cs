using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bileteria.Api.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("tickets")]
        public async Task<IActionResult> GetTickets()
        {
            throw new NotImplementedException();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post()
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Post()
        {
            throw new NotImplementedException();
        }
    }
}