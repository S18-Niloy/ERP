using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShippingAndLogistics()
        {
            return View();
        }
    }
}