using E_Commercial.Models;
using eCommercial.Business.Abstract;
using eCommercial.DataAccess.Concrete.EntityFramework;
using eCommercial.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_Commercial.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService _adminService;
        private CommercialContext _commercialContext;

        public AdminController(IAdminService adminService,CommercialContext commercialContext)
        {
            this._adminService = adminService;
            this._commercialContext = commercialContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            var admin = _commercialContext.Admins.Where(x=>x.AdminName=="admin").FirstOrDefault();
            if (admin == null)
            {
                var newAdmin = new Admin()
                {
                    AdminName = "admin",
                    AdminEmail = "root@admin.sys",
                    AdminPassword = "ablzz2w",
                    CreatedAt = DateTime.Now

                };
                _adminService.Create(newAdmin);
            }
                return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel adminLoginViewModel)
        {
            var admin = _commercialContext.Admins.Where(x => x.AdminName == "admin").FirstOrDefault();
            if (admin.AdminEmail == adminLoginViewModel.AdminMail && admin.AdminPassword == adminLoginViewModel.AdminPassword)
            {
                var claims = new List<Claim>
                {

                    new Claim(ClaimTypes.Name,adminLoginViewModel.AdminMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [Authorize]
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
