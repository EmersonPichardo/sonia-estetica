using System;

namespace sonia_estetica_dataAccess.Models.Security
{
    public class _Token
    {
        public byte[] Token { get; set; }
        public string Usuario { get; set; }
        public DateTime VigenteDesde { get; set; }

        public bool EstaVigente
        {
            get
            {
                return DateTimeOffset.Now.Subtract(new TimeSpan(0, 30, 0)) <= VigenteDesde;
            }
        }
    }
}
