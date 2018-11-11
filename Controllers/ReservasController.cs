using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models;
using Proyecto_Final.Models.Entidades;

namespace Proyecto_Final.Controllers
{
    public class ReservasController: Controller
    {
        private readonly Context _context;
        public ReservasController(Context context)
        {
            this._context = context;
        }
        public IActionResult Reserva()
        {
            return View();
        }

        [HttpPost]

         public IActionResult ProcesarReserva(Reserva res)
        {
            if (ModelState.IsValid)
            {
                _context.Add(res);
                _context.SaveChanges();

                return RedirectToAction("ReservaConfirmacion");
            }

            return View(res);
        }
        
        public IActionResult ReservaConfirmacion()
        {
            return View();
        }

       
    }
}