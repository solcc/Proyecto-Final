using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Final.Controllers
{
    public class ReservasController: Controller
    {
         public IActionResult Reservar()
        {
            return View();
        }
    }
}