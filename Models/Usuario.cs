using ANDyNAwebApp.Dtos;

namespace ANDyNAwebApp.Models
{
    public class Usuario
    {
        public string Cuenta { get; set; }
        public string NombreCompleto { get; set; }
        public string Password { get; set; }
        public RolEnum Rol { get; set; }
    }
}
