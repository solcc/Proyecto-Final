using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models;

namespace Proyecto_Final.Controllers
{
    public class CuentaController : Controller
    {
        
         private readonly Context _context;
        public CuentaController(Context context)
        {
            this._context = context;

        }
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Cliente c)
        {
            if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();

                return RedirectToAction("RegistroConfirmacion");
            }

            return View(c);
        }

        public IActionResult RegistroConfirmacion()
        {
            return View();
        }
    }
}