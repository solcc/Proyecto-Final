using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.Entidades
{
    public class Contacto
    {
        [Required]
        [Key]
        public int idContacto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Asunto { get; set; }
        [Required]
        public string Mensaje { get; set; }
    }
}