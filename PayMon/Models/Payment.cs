// File: PayMon/Models/Payment.cs

using System.ComponentModel.DataAnnotations.Schema;

namespace PayMon.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public string PaymentStatus { get; set; } = "Pending";

        [Column(TypeName = "decimal(18, 2)")] // Specifying precision and scale
        public decimal PaymentAmount { get; set; }
        
        public DateTime PaymentDate { get; set; }
    }
}

