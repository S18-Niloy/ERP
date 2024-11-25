using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers.Analytics
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
