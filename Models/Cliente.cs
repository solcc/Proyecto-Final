using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Cliente
    {
        [Required]
        public int idCliente { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Telefono { get; set; }

       
    }
}