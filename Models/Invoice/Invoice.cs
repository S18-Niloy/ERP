namespace ERP.Models.Invoice
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string CustomerName { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // "Paid", "Unpaid", etc.
    }
}
