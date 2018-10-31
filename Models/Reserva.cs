using System;

namespace Proyecto_Final.Models
{
    public class Reserva
    {
        public int codReserva { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public float Monto { get; set; }
        public Cliente Cliente { get; set; }
        public int? idCliente { get; set; }
    }
}