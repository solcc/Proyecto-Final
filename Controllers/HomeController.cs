using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto_Final.Models;
using Proyecto_Final.Models.Entidades;

namespace Proyecto_Final.Controllers
{
    public class HomeController : Controller
    {
         private readonly Context _context;
        public HomeController(Context context)
        {
            this._context = context;

        }
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contacto()
        {
            

            return View();
        }
        
        [HttpPost]
        public ActionResult ProcesarContacto(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contacto);
                _context.SaveChanges();

                TempData["contacto"] = JsonConvert.SerializeObject(contacto);

                return RedirectToAction("Confirmacion");
            }

            return View(contacto);
        }
        public ActionResult Confirmacion()
        {
            var x = TempData["contacto"].ToString();
            Contacto contacto = JsonConvert.DeserializeObject(x) as Contacto;
           
            ViewData["Contacto"] = contacto;
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
        
    }
}
