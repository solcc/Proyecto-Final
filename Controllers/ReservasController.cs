using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models;

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
        public IActionResult RegistroReserva(Cliente c)
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