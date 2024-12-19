using _231103011_Emirhan_CAN.Database;
using Microsoft.AspNetCore.Mvc;

namespace _231103011_Emirhan_CAN.Controllers
{
    public class AdminPanelController : Controller
    {

        KorkueviContext db;

        public AdminPanelController(KorkueviContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var dr = db.Personels.ToList();
            return View(dr);
        }

    }
}
