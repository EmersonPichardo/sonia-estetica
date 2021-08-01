using System;
using System.ComponentModel.DataAnnotations;

namespace sonia_estetica_dataAccess.Models.Benesser
{
    public class Servicio : ServicioDTO
    {
        public Cliente Cliente { get; set; }
        public Procedimiento Procedimiento { get; set; }
        public Promocion Promocion { get; set; }
    }

    public class ServicioDTO
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProcedimientoId { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}