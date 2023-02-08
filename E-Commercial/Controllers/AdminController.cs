using Microsoft.AspNetCore.Mvc;

namespace E_Commercial.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }



        #region Product
        #endregion
        #region Category
        #endregion
        #region Order
        #endregion


    }
}
