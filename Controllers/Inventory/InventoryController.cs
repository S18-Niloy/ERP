using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers.Inventory
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
