using GestionTienda.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionTienda.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        // Otros DbSet para tus otros modelos de datos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales para tus modelos de datos, como relaciones, índices, etc.
        }
    }
}
