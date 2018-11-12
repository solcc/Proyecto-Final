using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.ViewModels
{
    public class User
    {
         [Required]
        [Key]
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
         [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public string Password { get; set; }
        
        public int Telefono { get; set; }
    }
}