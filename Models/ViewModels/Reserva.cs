using System;
using System.ComponentModel.DataAnnotations;
using Proyecto_Final.Models.Entidades;

namespace Proyecto_Final.Models.ViewModels
{
    public class Reserva
    {
        [Key]
        public int codReserva { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public float Monto { get; set; }
        public Usuario Usuario { get; set; }
        public int? idUsuario { get; set; }
        public Menu Menu { get; set; }
        public int? idMenu { get; set; }
         public int numPersonas { get; set; }
    }
}