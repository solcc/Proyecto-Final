using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Models.Entidades;

namespace Proyecto_Final.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Cliente>().HasData(
                
                new Cliente {
                    idCliente=1,
                        Nombre ="Sol Milagros",
                        Apellido="Choque Chara",
                        Telefono=1256456778,
                     
                },
                new Cliente {
                     idCliente=2,
                    Nombre ="Yaneli ",
                        Apellido="Alayo Cuje",
                        Telefono=456845543,
                      
                }
            );
        }

        public DbSet<Menu> Menus{get; set;}
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Reserva> Reservas { get; set; }
    }
}