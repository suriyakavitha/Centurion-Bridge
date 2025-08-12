using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class DeviceConfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
