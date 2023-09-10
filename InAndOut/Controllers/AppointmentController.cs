using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();           
        }
    }
}
