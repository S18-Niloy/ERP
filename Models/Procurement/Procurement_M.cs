using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Procurement
{
    public class Procurement_M
    {
        [Key]
        public int ProcurementId { get; set; }

        [Required]
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        public string Status { get; set; } = "Pending";
    }
}
