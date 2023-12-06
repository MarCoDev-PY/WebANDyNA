using ANDyNAwebApp.Dtos;
using System.ComponentModel.DataAnnotations;

namespace ANDyNAwebApp.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Cuenta { get; set; }
        [Required]
        public required string NombreCompleto { get; set; }
        public string Foto { get; set; }
        [Required]
        public required string Password { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
    }
}
