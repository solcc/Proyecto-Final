using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.ViewModels
{
    public class Sesion
    {
         [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string Password { get; set; }
    }
}