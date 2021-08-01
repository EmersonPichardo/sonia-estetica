using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sonia_estetica_dataAccess.Models.Benesser
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Contacto { get; set; }
        public string Sector { get; set; }
        public int? TipoPielId { get; set; }
        public string Comentario { get; set; }
        [NotMapped]
        public string[] Alergias { get; set; }
        public TipoPiel TipoPiel { get; set; }
        [NotMapped]
        public Promocion[] PromocionesAdquiridas { get; set; }
    }
}