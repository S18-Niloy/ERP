using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers.Sales
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
