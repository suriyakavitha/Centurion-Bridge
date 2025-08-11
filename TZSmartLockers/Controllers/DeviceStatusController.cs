using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class DeviceStatusController : Controller
    {
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("User");

            if (string.IsNullOrEmpty(user))
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

    }
}
