using Microsoft.AspNetCore.Mvc;

namespace E_Commercial.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
