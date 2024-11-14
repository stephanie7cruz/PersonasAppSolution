using Microsoft.EntityFrameworkCore;
using PersonasApp.Models;

namespace PersonasApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Persona> Personas { get; set; }
    }
}
