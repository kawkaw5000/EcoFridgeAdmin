using Microsoft.AspNetCore.Mvc;

namespace AdminSideEcoFridge.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            return RedirectToAction("Dashboard", "Home");
        }
    }
}
