using Microsoft.EntityFrameworkCore;

namespace ACLEDABank.Models
{
    public class ACLEDABankContext : DbContext
    {
        public ACLEDABankContext(DbContextOptions options)
            : base(options) { }
        
            // This = tblBankAccounts in database
            public DbSet<BankAccount> BankAccounts { get; set; }
        
    }
}
