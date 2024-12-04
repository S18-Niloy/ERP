using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Warehouse
{
    public class Warehouse_M
    {
        [Key]
        public int WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public ICollection<StockItem> StockItems { get; set; }
    }

    public class StockItem
    {
        [Key]
        public int StockItemId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse_M Warehouse { get; set; }
    }
}
