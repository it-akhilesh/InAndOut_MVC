using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
                
        }
        public IActionResult Index()
        {
            List<Item> objItemlist = _db.Items.ToList();
            return View(objItemlist);
        }
    }
}
