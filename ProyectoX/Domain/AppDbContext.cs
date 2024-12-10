using Microsoft.EntityFrameworkCore;
using ProyectoX.Domain;

namespace ProyectoX
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define las tablas (DbSet)
        public DbSet<User> Users { get; set; }
    }
}
