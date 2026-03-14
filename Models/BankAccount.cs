using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACLEDABank.Models
{
    [Table("tblBankAccounts")]
    public class BankAccount : IBankService
    {
        // Properties 
        [Key]
        public int ID { get; set; }
        public string OwnerName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Interface methods
        public void Deposit(decimal amount)
        { 
            if (amount > 0) Balance += amount;
        }

        public void Withdraw(decimal amount)
        { 
            if (amount > 0 && amount <= Balance) 
                Balance -= amount;
        }

        public virtual string GetAccountType()
        {
            return "Basic Bank Account";
        }

        public decimal GetBalance()
        {
            return Balance;
        }



    }
}
