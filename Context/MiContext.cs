using ANDyNAwebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ANDyNAwebApp.Context
{
    public class MiContext : DbContext
    {
        public MiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

        //REVISAR SI LA ES NECESARIO UNA BASE DE DATOS PARA LOS CLIENTES
        public DbSet<Cliente> Cliente { get; set; }

        //REVISAR SI LAS RESERVAS TAMBIEN ESTARAN EN LA BASE DE DATOS
        //public DbSet<Reserva> reservas { get; set; }
    }
}