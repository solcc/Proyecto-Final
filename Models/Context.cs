using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Models.Entidades;

namespace Proyecto_Final.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Usuario>().HasData(
                
                new Usuario {
                    idUsuario=1,
                        Nombre ="Sol Milagros",
                        Correo="sol.choque@usil.pe",
                        Password="12345",
                        Apellido="Choque Chara",
                        Telefono=1256456778
                        
                     
                },
                new Usuario {
                     idUsuario=2,
                    Nombre ="Yaneli ",
                     Correo="yaneli.alayo@usil.pe",
                        Password="678910",
                        Apellido="Alayo Cuje",
                        Telefono=456845543
                      
                }
            );
        }

        public DbSet<Menu> Menus{get; set;}
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
    }
}