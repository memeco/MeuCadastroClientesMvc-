using Microsoft.EntityFrameworkCore;
using MeuCadastroClientesMvc.Models;

namespace MeuCadastroClientesMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ID_Cliente);
        }
    }
}

