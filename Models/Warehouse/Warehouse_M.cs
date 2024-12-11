using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Warehouse
{
    public class Warehouse_M
    {
        [Key]
        public int WarehouseId { get; set; }

        [Required(ErrorMessage = "Warehouse name is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(200)]
        public string Location { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Capacity must be a positive number.")]
        public int Capacity { get; set; }

        public int CurrentStock { get; set; }
    }
}
