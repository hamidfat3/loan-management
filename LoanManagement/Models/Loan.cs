using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Models { 
    public class Loan
    {
        [Key]
        [Column("Loan_ID")]
        public int LoanId { get; set; }
    
        [Column("receiver_national_id")]
        public string ReceiverNationalId { get; set; }  // اینجا مقدار `NationalId` در جدول Users قرار دارد.
    
        [Column("pay_date")]
        public string PayDate { get; set; }
    
        [Column("first_installment_date")]
        public string FirstInstallmentDate { get; set; }
    
        [Column("loan_amount")]
        public decimal LoanAmount { get; set; }
    
        [Column("installments_num")]
        public int InstallmentsNum { get; set; }
    
        [Column("fee")]
        public decimal Fee { get; set; }
    
        [Column("remaining_installments")]
        public int RemainingInstallments { get; set; }
    
        [Column("remaining_amount")]
        public decimal RemainingAmount { get; set; }
    
        [Column("paid")]
        public bool Paid { get; set; }
    
        [Column("note")]
        public string? Note { get; set; }
    }
}