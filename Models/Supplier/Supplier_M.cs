using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Supplier
{
    public class Supplier_M
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        public string Name { get; set; }

        public string ContactDetails { get; set; }
        public string PerformanceRating { get; set; }
        public string ContractDetails { get; set; }
    }
}
