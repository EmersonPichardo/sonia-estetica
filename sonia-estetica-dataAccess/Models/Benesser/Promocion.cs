using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sonia_estetica_dataAccess.Models.Benesser
{
    public class Promocion : PromocionDTO
    {
        public Cliente Cliente { get; set; }
        public Procedimiento Procedimiento { get; set; }

        [NotMapped]
        public string Estado
        {
            get
            {
                if (ValidoHasta > DateTime.Now) return _Estado.Vencida.ToString();
                if (Restantes < 1) return _Estado.Agotada.ToString();

                return _Estado.Vigente.ToString();
            }
        }
    }

    public class PromocionDTO
    {
        [Key]
        public string Id { get; set; }
        public int ClienteId { get; set; }
        public int ProcedimientoId { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime ValidoDesde { get; set; }
        public DateTime ValidoHasta { get; set; }
        public int Restantes { get; set; }

        public enum _Estado
        {
            Vigente = 1,
            Vencida = 2,
            Agotada = 3
        }
    }
}
