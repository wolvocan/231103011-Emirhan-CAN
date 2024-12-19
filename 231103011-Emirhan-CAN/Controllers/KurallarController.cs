using _231103011_Emirhan_CAN.Database;
using _231103011_Emirhan_CAN.Models;
using Microsoft.AspNetCore.Mvc;

namespace _231103011_Emirhan_CAN.Controllers
{
    public class KurallarController : Controller
    {
        private readonly KorkueviContext database;
        public KurallarController(KorkueviContext db)
        {
            database = db;
        }
        
        public IActionResult Index()
        {
            var kurallar = database.Kurallars.ToList();
            var iletisim = database.Iletisims.ToList();

            // ViewModel'e veriyi doldur
            var viewModel = new KurallarViewModel
            {
                KurallarListesi = kurallar,
                IletisimListesi = iletisim
            };
            return View(viewModel);
        }
    }
}
