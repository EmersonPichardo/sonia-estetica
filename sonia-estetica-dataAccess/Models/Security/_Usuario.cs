namespace sonia_estetica_dataAccess.Models.Security
{
    public class _Usuario
    {
        public string Usuario { get; set; }
        public byte[] Contrasenia { get; set; }
        public byte[] Sal { get; set; }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
