using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Customer
{
    public class Customer_M
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer name is required.")]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
