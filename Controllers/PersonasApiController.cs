using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonasApp.Data;
using PersonasApp.Models;

namespace PersonasApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonasApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{nombres}")]
        public async Task<IActionResult> GetPersona(string nombres)
        {
            var persona = await _context.Personas
                .FirstOrDefaultAsync(p => p.Nombres == nombres);

            if (persona == null)
                return NotFound();

            return Ok(persona);
        }
    }
}
