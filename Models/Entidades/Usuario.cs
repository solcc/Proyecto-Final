using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.Entidades
{
    public class Usuario
    {
        [Required]
        [Key]
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        
         [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public string Password { get; set; }
        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public List<Reserva> Reservas { get; set; }
    }
}