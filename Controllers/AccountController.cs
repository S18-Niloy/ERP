using ERP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers
{
    public class AccountController : Controller
    {
        private const string SessionKeyUsername = "Username";

        // Mock user data for demonstration
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>
        {
            { "admin", "password" },
            { "user", "password123" }
        };

        public static Dictionary<global::System.String, global::System.String> Users1 => Users;

        // Show the login form
        public IActionResult Login()
        {
            return View();
        }

        // Handle login form submission
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (Users1.TryGetValue(model.Username, out var password) && password == model.Password)
                {
                    // Set session for the logged-in user
                    HttpContext.Session.SetString(SessionKeyUsername, model.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }
            return View(model);
        }

        // Logout and clear session
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKeyUsername);
            return RedirectToAction("Login");
        }
    }
}
