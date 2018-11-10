using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models;
using Proyecto_Final.Models.Entidades;
using Proyecto_Final.Models.ViewModels;

namespace Proyecto_Final.Controllers
{
    public class CuentaController : Controller
    {
        
         private readonly Context _context;
        public CuentaController(Context context)
        {
            this._context = context;

        }
        public IActionResult Login()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Validacion(Sesion sesion)
        {
            if (ModelState.IsValid)
            {
                if (sesion.Correo=="sol.choque@usil.pe"&&sesion.Password=="123456")
                {
                    TempData["validacion"] = "valida";
                    return RedirectToAction("Inicio", "Home");
                }
                ModelState.AddModelError("error","Error en los datos");
            }
            return View("Login", sesion);
        }
        public IActionResult Registro()
        {
            ViewData["Message"] = "";

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