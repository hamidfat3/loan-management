using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace LoanManagement.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<Payment> payments { get; set; }


    }
}
