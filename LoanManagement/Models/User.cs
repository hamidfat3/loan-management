using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Models { 
    public class User
    {
        [Key]
        [Column("national_id")]
        public string NationalId { get; set; }
    
        [Column("firstname")]
        public string FirstName { get; set; }
    
        [Column("lastname")]
        public string LastName { get; set; }
    
        [Column("father_name")]
        public string FatherName { get; set; }
    
        [Column("phonenum")]
        public string PhoneNumber { get; set; }
    
        [Column("email")]
        public string? Email { get; set; }
    
        [Column("home_number")]
        public string? HomeNumber { get; set; }
    
        [Column("birth_date")]
        public string BirthDate { get; set; }
    
        [Column("address")]
        public string Address { get; set; }
    
        [Column("postal_code")]
        public string? PostalCode { get; set; }
    
        [Column("registery_date")]
        public string RegisteryDate { get; set; }
    
        [Column("loans_received")]
        public int LoansReceived { get; set; }
    
        [Column("balance")]
        public decimal Balance { get; set; }
    
        [Column("debt")]
        public decimal Debt { get; set; }
    
        [Column("remaining_installments")]
        public int RemainingInstallments { get; set; }
    
        [Column("active_loan")]
        public bool ActiveLoan { get; set; }
    
        [Column("password")]
        public string Password { get; set; }
    }
}