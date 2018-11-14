using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models;
using Proyecto_Final.Models.Entidades;

namespace Proyecto_Final.Controllers
{
    public class SesionController: Controller
    {  
        public IActionResult Panel()
        {
            return View("Panel","_LayoutSesion");
        }
    }
}