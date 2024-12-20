using ERP.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers.Customer
{
    public class CustomerController : Controller
    {
        private static List<Customer_M> customers = new List<Customer_M>();
        private static int nextCustomerId = 1;

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer_M customer)
        {
            if (ModelState.IsValid)
            {
                customer.CustomerId = nextCustomerId++;
                customers.Add(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}
