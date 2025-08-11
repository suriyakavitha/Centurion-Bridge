using Microsoft.AspNetCore.Mvc;

namespace TZSmartLockers.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            //ViewBag.Username = username;
            //if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            //{
            //    ViewBag.Error = "Username and Password are required.";
            //}
            //else if (string.IsNullOrWhiteSpace(username))
            //{
            //    ViewBag.Error = "Username is required.";
            //}
            //else if (string.IsNullOrWhiteSpace(password))
            //{
            //    ViewBag.Error = "Password is required.";
            //}
            if (username == "admin" && password == "123456")
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "DeviceStatus");
            }
            //else
            //{
            //    ViewBag.Error = "Invalid username or password.";
            //}
            return View("Index");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
