using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class EventLogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
