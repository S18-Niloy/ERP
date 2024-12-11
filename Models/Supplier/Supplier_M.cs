using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Supplier
{
    public class Supplier_M
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        public string Name { get; set; }

        public string ContactDetails { get; set; }

        [Range(1, 5, ErrorMessage = "Performance rating must be between 1 and 5.")]
        public string PerformanceRating { get; set; }

        public string ContractDetails { get; set; }
    }
}
