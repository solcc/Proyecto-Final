using System.Linq;
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
            if (ModelState.IsValid){

            var user=_context.Usuario.FirstOrDefault(u=>u.Correo==sesion.Correo
            &&u.Password==sesion.Password);
                if(user!=null){
                    TempData["validacion"] = "valida";
                    return RedirectToAction("Panel", "Sesion");
                }
                ModelState.AddModelError("error","Error en los datos");
            }
            return View("Login", sesion);
            
            
        }
        public IActionResult Registro()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult ProcesarRegistro(Usuario user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();

                return RedirectToAction("RegistroConfirmacion");
            }

            return View(user);
        }

        public IActionResult RegistroConfirmacion()
        {
            return View();
        }
    }
}