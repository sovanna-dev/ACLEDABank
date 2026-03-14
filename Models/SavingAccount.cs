namespace ACLEDABank.Models
{
    public class SavingAccount : BankAccount
    { 
        // Extra property only SavingAccount has
        public decimal InterestRate { get; set; }

        // Extra method only SavingAccount has 
        public void AddInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Deposit(interest); // Reuse Deposit method from BankAccount
        }
    }
}
