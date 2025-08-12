using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class AboutCenturionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
