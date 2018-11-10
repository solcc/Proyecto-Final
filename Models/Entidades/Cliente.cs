using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.Entidades
{
    public class Cliente
    {
        [Required]
        [Key]
        public int idCliente { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public List<Reserva> Reservas { get; set; }
    }
}