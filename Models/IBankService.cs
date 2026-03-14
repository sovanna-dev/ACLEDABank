namespace ACLEDABank.Models
{
    public interface IBankService
    {
        // Contract! Any class using this 
        // Must implement these methods!
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        string GetAccountType();
        decimal GetBalance();


    }
}
