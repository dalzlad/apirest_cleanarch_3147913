using APIConcesionario.Models;
using Microsoft.EntityFrameworkCore;

namespace APIConcesionario.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ciudad> ciudades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Ciudad)
                .WithMany()
                .HasForeignKey(c => c.IdCiudad)
                .OnDelete(DeleteBehavior.Cascade);
        }

        }
    }
