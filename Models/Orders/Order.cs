using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Orders
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Status { get; set; } // Pending, Processed, Canceled
    }
}
