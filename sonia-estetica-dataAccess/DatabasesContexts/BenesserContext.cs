using Microsoft.EntityFrameworkCore;
using sonia_estetica_dataAccess.Models.Benesser;

namespace sonia_estetica_dataAccess.Connections
{
    public class BenesserContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cliente_Alergia> Clientes_alergias { get; set; }
        public DbSet<Procedimiento> Procedimientos { get; set; }
        public DbSet<Promocion> Promociones { get; set; }
        public DbSet<PromocionUso> PromocionesUsos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoPiel> TiposPiel { get; set; }

        public BenesserContext(DbContextOptions<BenesserContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Cliente_Alergia>().ToTable("Clientes_Alergias");
            modelBuilder.Entity<Procedimiento>().ToTable("Procedimientos");
            modelBuilder.Entity<Promocion>().ToTable("Promociones");
            modelBuilder.Entity<PromocionUso>().ToTable("PromocionesUsos");
            modelBuilder.Entity<Servicio>().ToTable("Servicios");
            modelBuilder.Entity<TipoPiel>().ToTable("Tipospiel");

            modelBuilder.Entity<Cliente_Alergia>().HasKey(ca => new { ca.ClienteId, ca.Alergia });
            modelBuilder.Entity<PromocionUso>().HasKey(pu => new { pu.PromocionId, pu.ServicioId });
        }
    }
}
