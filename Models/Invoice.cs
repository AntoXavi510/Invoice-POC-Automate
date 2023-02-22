using System.ComponentModel.DataAnnotations;

namespace Invoice_POC_Automate.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public string? InvoiceId { get; set; }
        public string? Billto { get; set; }
        public string? Contact { get;set; }
        public string? Date { get; set; }
        public string? Amount { get; set; }
    }
}
