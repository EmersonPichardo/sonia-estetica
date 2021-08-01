using System.ComponentModel.DataAnnotations;

namespace sonia_estetica_dataAccess.Models.Benesser
{
    public class Procedimiento
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}