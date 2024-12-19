using _231103011_Emirhan_CAN.Database;
using Microsoft.AspNetCore.Mvc;

namespace _231103011_Emirhan_CAN.Controllers
{
    public class IletisimController : Controller
    {
        KorkueviContext db;

        public IletisimController(KorkueviContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var dr = db.Iletisims.ToList();
            return View(dr);
        }
    }
}
