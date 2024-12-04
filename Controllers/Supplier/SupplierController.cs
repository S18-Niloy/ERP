using ERP.Models.Supplier;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ERP.Controllers.Supplier
{
    public class SupplierController : Controller
    {
        private static List<Supplier_M> suppliers = new List<Supplier_M>();

        public IActionResult Index()
        {
            return View(suppliers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier_M supplier)
        {
            suppliers.Add(supplier);
            return RedirectToAction("Index");
        }
    }
}
