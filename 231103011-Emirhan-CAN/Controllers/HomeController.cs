using _231103011_Emirhan_CAN.Database;
using _231103011_Emirhan_CAN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _231103011_Emirhan_CAN.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly KorkueviContext database;
        public HomeController(ILogger<HomeController> logger, KorkueviContext db)
		{
			_logger = logger;
            database = db;
		}

        public IActionResult Index()
		{
            var bilgi = database.Bilgilers.ToList();
            var iletisim = database.Iletisims.ToList();

           
            var viewModel = new AnasayfaViewModel
            {
                AnasayfaListesi = bilgi,
                IletisimListesi = iletisim
            };
            return View(viewModel);
        }

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
