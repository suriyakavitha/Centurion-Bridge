using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class UsersController: Controller
    {
        public IActionResult Logins()
        {
            return View();
        }

        public IActionResult RFID()
        {
            return View();
        }
    }
}
