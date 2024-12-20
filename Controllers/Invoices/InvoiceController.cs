using Microsoft.AspNetCore.Mvc;
using ERP.Models.Invoice;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers.Invoices
{
    public class InvoiceController : Controller
    {
        // Temporary in-memory storage for invoices
        private static List<Invoice> Invoices = new List<Invoice>
        {
            new Invoice { InvoiceId = 1, CustomerName = "John Doe", InvoiceDate = System.DateTime.Now, TotalAmount = 1500.00m, Status = "Paid" },
            new Invoice { InvoiceId = 2, CustomerName = "Jane Smith", InvoiceDate = System.DateTime.Now, TotalAmount = 200.00m, Status = "Unpaid" }
        };

        // GET: /Invoice/
        public IActionResult Index()
        {
            return View(Invoices);
        }

        // GET: /Invoice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Invoice/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                invoice.InvoiceId = Invoices.Any() ? Invoices.Max(i => i.InvoiceId) + 1 : 1; // Generate new ID
                Invoices.Add(invoice);
                return RedirectToAction(nameof(Index));
            }
            return View(invoice);
        }

        // GET: /Invoice/Edit/5
        public IActionResult Edit(int id)
        {
            var invoice = Invoices.FirstOrDefault(i => i.InvoiceId == id);
            if (invoice == null) return NotFound();
            return View(invoice);
        }

        // POST: /Invoice/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                var existingInvoice = Invoices.FirstOrDefault(i => i.InvoiceId == invoice.InvoiceId);
                if (existingInvoice == null) return NotFound();

                existingInvoice.CustomerName = invoice.CustomerName;
                existingInvoice.InvoiceDate = invoice.InvoiceDate;
                existingInvoice.TotalAmount = invoice.TotalAmount;
                existingInvoice.Status = invoice.Status;

                return RedirectToAction(nameof(Index));
            }
            return View(invoice);
        }

        // GET: /Invoice/Details/5
        public IActionResult Details(int id)
        {
            var invoice = Invoices.FirstOrDefault(i => i.InvoiceId == id);
            if (invoice == null) return NotFound();
            return View(invoice);
        }

        // GET: /Invoice/Delete/5
        public IActionResult Delete(int id)
        {
            var invoice = Invoices.FirstOrDefault(i => i.InvoiceId == id);
            if (invoice == null) return NotFound();
            return View(invoice);
        }

        // POST: /Invoice/DeleteConfirmed/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var invoice = Invoices.FirstOrDefault(i => i.InvoiceId == id);
            if (invoice != null) Invoices.Remove(invoice);
            return RedirectToAction(nameof(Index));
        }
    }
}
