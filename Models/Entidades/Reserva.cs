using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.Entidades
{
    public class Reserva
    {
        [Key]
        public int codReserva { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
         public int numPersonas { get; set; }

        public Usuario Usuario { get; set; }
        public int? idUsuario { get; set; }


    }
}