using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class AlarmConfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
