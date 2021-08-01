using Microsoft.EntityFrameworkCore;
using sonia_estetica_dataAccess.Models.Security;

namespace sonia_estetica_dataAccess.Connections
{
    public class SecurityContext : DbContext
    {
        public DbSet<_Token> Tokens { get; set; }
        public DbSet<_Usuario> Usuarios { get; set; }

        public SecurityContext(DbContextOptions<SecurityContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_Token>().ToTable("Tokens");
            modelBuilder.Entity<_Usuario>().ToTable("Usuarios");
        }
    }
}
