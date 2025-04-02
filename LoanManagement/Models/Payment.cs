using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Models { 
    public class Payment
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    
        [Column("payment_type")]
        public string PaymentType { get; set; }
    
        [Column("payment_amount")]
        public decimal PaymentAmount { get; set; }
    
        [Column("national_id_payer")]
        public string NationalIdPayer { get; set; }  // اینجا مقدار `NationalId` از جدول Users قرار دارد.
    
        [Column("pay_date")]
        public string PayDate { get; set; }
    
        [Column("note")]
        public string? Note { get; set; }
    }
}