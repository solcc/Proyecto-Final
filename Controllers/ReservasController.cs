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
        public IActionResult RegistroReserva()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistroReserva(Usuario c)
        {
            if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();
                

                return RedirectToAction("RegistroReservaConfirmacion");
            }

            return View(c);
        }

        public IActionResult RegistroReservaConfirmacion()
        {
            return View();
        }
    }
}