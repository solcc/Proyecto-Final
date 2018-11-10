using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.ViewModels
{
    public class Contacto
    {
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