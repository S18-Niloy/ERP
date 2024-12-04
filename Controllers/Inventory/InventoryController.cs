using Microsoft.AspNetCore.Mvc;
using ERP.Models.Inventory;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers.Inventory
{
    public class InventoryController : Controller
    {
        // Simulating a database with a static list
        private static List<InventoryItem> _inventory = new List<InventoryItem>
        {
            new InventoryItem { Id = 1, Name = "Item A", Quantity = 100, Price = 10.00m, Supplier = "Supplier A" },
            new InventoryItem { Id = 2, Name = "Item B", Quantity = 50, Price = 20.00m, Supplier = "Supplier B" }
        };

        public IActionResult Index()
        {
            return View(_inventory);
        }

        public IActionResult Details(int id)
        {
            var item = _inventory.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InventoryItem item)
        {
            if (ModelState.IsValid)
            {
                item.Id = _inventory.Max(i => i.Id) + 1;
                _inventory.Add(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            var item = _inventory.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(InventoryItem item)
        {
            if (ModelState.IsValid)
            {
                var existingItem = _inventory.FirstOrDefault(i => i.Id == item.Id);
                if (existingItem != null)
                {
                    existingItem.Name = item.Name;
                    existingItem.Quantity = item.Quantity;
                    existingItem.Price = item.Price;
                    existingItem.Supplier = item.Supplier;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = _inventory.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _inventory.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _inventory.Remove(item);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
