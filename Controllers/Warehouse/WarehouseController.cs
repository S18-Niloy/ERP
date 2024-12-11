using ERP.Models.Warehouse;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ERP.Controllers.Warehouse
{
    public class WarehouseController : Controller
    {
        private static List<Warehouse_M> warehouses = new List<Warehouse_M>();
        private static int nextWarehouseId = 1; // Initialize ID counter

        // Display list of warehouses
        public IActionResult Index()
        {
            return View(warehouses);
        }

        // Show form to create a new warehouse
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission to create a new warehouse
        [HttpPost]
        public IActionResult Create(Warehouse_M warehouse)
        {
            if (ModelState.IsValid)
            {
                warehouse.WarehouseId = nextWarehouseId++; // Assign a unique ID
                warehouses.Add(warehouse);
                return RedirectToAction("Index");
            }
            return View(warehouse);
        }

        // Show details of a specific warehouse
        public IActionResult Details(int id)
        {
            var warehouse = warehouses.Find(w => w.WarehouseId == id);
            if (warehouse == null)
            {
                return NotFound();
            }
            return View(warehouse);
        }
    }
}
