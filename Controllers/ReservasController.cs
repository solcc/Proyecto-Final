using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Final.Controllers
{
    public class ReservasController: Controller
    {
         public IActionResult RegistroReserva()
        {
            return View();
        }
    }
}