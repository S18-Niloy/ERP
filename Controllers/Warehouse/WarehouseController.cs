using ERP.Models.Warehouse;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers.Warehouse
{
    public class WarehouseController : Controller
    {
        private static List<Warehouse_M> warehouses = new List<Warehouse_M>();

        public IActionResult Index()
        {
            return View(warehouses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Warehouse_M warehouse)
        {
            warehouses.Add(warehouse);
            return RedirectToAction("Index");
        }
    }
}
