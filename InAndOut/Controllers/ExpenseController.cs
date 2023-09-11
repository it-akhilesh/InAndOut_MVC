using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
