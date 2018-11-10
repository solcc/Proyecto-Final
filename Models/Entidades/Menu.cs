using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.Entidades
{
    public class Menu
    {
        [Required]
        [Key]
        public int idMenu { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
         public List<Reserva> Reserva{ get; set; }
    }
}