using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models;

namespace Proyecto_Final.Controllers
{
    public class HomeController : Controller
    {
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
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Reserva()
        {
            ViewData["Message"] = ".";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
