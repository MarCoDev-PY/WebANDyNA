using System.ComponentModel.DataAnnotations;

namespace ANDyNAwebApp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CI { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int Celular { get; set; }
        [Required]
        public DateTime FechaReserva { get; set; }
    }
}