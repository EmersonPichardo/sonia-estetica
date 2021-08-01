using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sonia_estetica_dataAccess.Models.Benesser
{
    public class Cliente_Alergia
    {
        public int ClienteId { get; set; }
        public string Alergia { get; set; }
    }
}