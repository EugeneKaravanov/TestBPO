using Microsoft.EntityFrameworkCore;
using CalculatorService.Models;

namespace CalculatorService.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Log> Log { get; set; }
    }
}
