using Microsoft.EntityFrameworkCore;
using TableTennis.Models;

namespace TableTennis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Result> Results { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
