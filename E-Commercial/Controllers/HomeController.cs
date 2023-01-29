using E_Commercial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commercial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Partial Views
        // Banner Section, Show 2 most popular product in this partial.
        public PartialViewResult BannerPartial()
        {
            return PartialView();
        }
        // New Products Section, Choice last  10 product and show this partial.
        public PartialViewResult NewProductsPartial()
        {
            return PartialView();
        }
        // Company Detail.
        public PartialViewResult CompanyDescriptionPartial()
        {
            return PartialView();
        }
        // News on newspaper and blog writer.
        public PartialViewResult NewsAndBlogsPartial()
        {
            return PartialView();
        }
        #endregion
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