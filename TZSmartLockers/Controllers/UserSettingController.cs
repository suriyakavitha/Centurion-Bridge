using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class UserSettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
