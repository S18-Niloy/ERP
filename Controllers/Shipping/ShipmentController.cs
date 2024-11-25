using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers.Shipping
{
    public class ShipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
