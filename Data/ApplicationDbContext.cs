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
    }
}
