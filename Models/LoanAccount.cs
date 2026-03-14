namespace ACLEDABank.Models
{
    public class LoanAccount : BankAccount
    {
       public decimal LoanAmount { get; set; }
       public int LoanMonths { get; set; }
        public decimal MonthlyPayment()
        {
             return LoanAmount / LoanMonths;
        }
    }
}
