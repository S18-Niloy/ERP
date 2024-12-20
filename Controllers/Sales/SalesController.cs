using Microsoft.AspNetCore.Mvc;
using ERP.Models.Sales;
using System.Linq;
using System.Collections.Generic;

namespace ERP.Controllers.Sales
{
    public class SalesController : Controller
    {
        // Temporary in-memory storage for sales
        private static List<Sale> Sales = new List<Sale>
        {
            new Sale { SaleId = 1, CustomerName = "John Doe", ItemName = "Laptop", Quantity = 1, TotalPrice = 1000.00m, Date = System.DateTime.Now },
            new Sale { SaleId = 2, CustomerName = "Jane Smith", ItemName = "Mouse", Quantity = 2, TotalPrice = 40.00m, Date = System.DateTime.Now }
        };

        // GET: /Sales/
        public IActionResult Index()
        {
            return View(Sales);
        }

        // GET: /Sales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Sales/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sale sale)
        {
            if (ModelState.IsValid)
            {
                sale.SaleId = Sales.Any() ? Sales.Max(s => s.SaleId) + 1 : 1; // Generate new ID
                Sales.Add(sale);
                return RedirectToAction(nameof(Index));
            }
            return View(sale);
        }

        // GET: /Sales/Edit/5
        public IActionResult Edit(int id)
        {
            var sale = Sales.FirstOrDefault(s => s.SaleId == id);
            if (sale == null) return NotFound();
            return View(sale);
        }

        // POST: /Sales/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Sale sale)
        {
            if (ModelState.IsValid)
            {
                var existingSale = Sales.FirstOrDefault(s => s.SaleId == sale.SaleId);
                if (existingSale == null) return NotFound();

                existingSale.CustomerName = sale.CustomerName;
                existingSale.ItemName = sale.ItemName;
                existingSale.Quantity = sale.Quantity;
                existingSale.TotalPrice = sale.TotalPrice;
                existingSale.Date = sale.Date;

                return RedirectToAction(nameof(Index));
            }
            return View(sale);
        }

        // GET: /Sales/Details/5
        public IActionResult Details(int id)
        {
            var sale = Sales.FirstOrDefault(s => s.SaleId == id);
            if (sale == null) return NotFound();
            return View(sale);
        }

        // GET: /Sales/Delete/5
        public IActionResult Delete(int id)
        {
            var sale = Sales.FirstOrDefault(s => s.SaleId == id);
            if (sale == null) return NotFound();
            return View(sale);
        }

        // POST: /Sales/DeleteConfirmed/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var sale = Sales.FirstOrDefault(s => s.SaleId == id);
            if (sale != null) Sales.Remove(sale);
            return RedirectToAction(nameof(Index));
        }
    }
}
