using ERP.Models.Orders;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers.Orders
{
    public class OrderManagementController : Controller
    {
        private static List<Order> _orders = new List<Order>();

        public IActionResult Index()
        {
            return View(_orders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderId = _orders.Count + 1;
                order.Status = "Pending";
                _orders.Add(order);
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public IActionResult Process(int id)
        {
            var order = _orders.FirstOrDefault(o => o.OrderId == id);
            if (order != null)
            {
                order.Status = "Processed";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Cancel(int id)
        {
            var order = _orders.FirstOrDefault(o => o.OrderId == id);
            if (order != null)
            {
                order.Status = "Canceled";
            }
            return RedirectToAction("Index");
        }
    }
}
