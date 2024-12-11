using ERP.Models.Supplier;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers.Supplier
{
    public class SupplierController : Controller
    {
        private static List<Supplier_M> suppliers = new List<Supplier_M>();
        private static int nextSupplierId = 1; // Initialize ID counter

        // Display the list of suppliers
        public IActionResult Index()
        {
            return View(suppliers);
        }

        // Show the form to create a new supplier
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission to create a new supplier
        [HttpPost]
        public IActionResult Create(Supplier_M supplier)
        {
            if (ModelState.IsValid)
            {
                supplier.SupplierId = nextSupplierId++; // Assign a unique ID
                suppliers.Add(supplier);
                return RedirectToAction("Index");
            }
            return View(supplier);
        }
    }
}
