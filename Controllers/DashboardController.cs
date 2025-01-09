using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}