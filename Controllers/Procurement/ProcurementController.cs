using ERP.Models.Procurement;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Controllers
{
    public class ProcurementController : Controller
    {
        private static List<Procurement_M> procurements = new List<Procurement_M>();

        public IActionResult Index()
        {
            return View(procurements);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Procurement_M procurement)
        {
            procurement.ProcurementId = procurements.Count + 1;
            procurements.Add(procurement);
            return RedirectToAction("Index");
        }

        public IActionResult Approve(int id)
        {
            var procurement = procurements.FirstOrDefault(p => p.ProcurementId == id);
            if (procurement != null)
            {
                procurement.Status = "Approved";
            }
            return RedirectToAction("Index");
        }
    }
}
