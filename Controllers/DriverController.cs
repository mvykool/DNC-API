using DNC_API.Data;
using Microsoft.AspNetCore.Mvc;
using DNC_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DNC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {

        private readonly ILogger<DriverController> _logger;

        private readonly ApiDbContext _context;

        public DriverController( ILogger<DriverController> logger, ApiDbContext context )
        {
            _logger = logger;
            _context = context;
           
        }

        [HttpGet(Name = "GetAllDrivers")]

        public async Task<IActionResult> Get()
        {
            var driver = new Driver()
            {
                DriverNumber = 44,
                Name = "sir leis"
            };

            _context.Add(driver);
            await _context.SaveChangesAsync();

            var allDrivers = await _context.Drivers.ToListAsync();

            return Ok(allDrivers);
        }
    }
}
