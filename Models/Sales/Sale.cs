using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Sales
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Total Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal TotalPrice { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
