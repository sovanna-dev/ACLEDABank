namespace ACLEDABank.Models
{
    public class BankAccount
    {
        // Properties 
        public string OwnerName { get; set; }
        public string AccountNumber { get; set; }
        // Private = hidden inside, nobody can touch
        private decimal _balance;
        // Public = safe way to READ balance
        public decimal Balance
        {
            get { return _balance; }
        }

        // Method: Deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        // Method: Withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
        }


    }
}
