using Microsoft.EntityFrameworkCore;

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
                       /* fechaNac="10/10/2018"*/ 
                },
                new Cliente {
                     idCliente=2,
                    Nombre ="Yaneli ",
                        Apellido="Alayo Cuje",
                        Telefono=456845543,
                        /* fechaNac=Convert.ToDateTime("10/20/2018")*/
                }
            );
        }

        public DbSet<Menu> Menus{get; set;}
    }
}