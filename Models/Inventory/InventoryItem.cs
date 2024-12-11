using System.ComponentModel.DataAnnotations;
namespace ERP.Models.Inventory
{
    public class InventoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be a positive number.")]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [StringLength(200)]
        public string Supplier { get; set; }
    }
}