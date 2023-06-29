using DNC_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DNC_API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base (options)
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
    }
}
