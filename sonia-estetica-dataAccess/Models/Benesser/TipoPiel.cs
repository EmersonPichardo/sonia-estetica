using System.ComponentModel.DataAnnotations;

namespace sonia_estetica_dataAccess.Models.Benesser
{
    public class TipoPiel
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
    }
}