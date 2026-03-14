using System.Diagnostics;
using ACLEDABank.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACLEDABank.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(BankAccount account)
        {
            ViewBag.Success = "Account created for: " + account.OwnerName;
            return View(account);
        }

        public IActionResult About()
        {
            BankAccount account = new BankAccount();
            account.OwnerName = "Sovanna";
            account.AccountNumber = "ACC-001";

            // Test Deposit and Withdraw
            account.Deposit(1000);
            account.Deposit(3000);
            account.Withdraw(500);

            ViewBag.Owner = account.OwnerName;
            ViewBag.Balance = account.Balance;

            // Saving Account 
            SavingAccount saving = new SavingAccount();
            saving.OwnerName = "Sovanna";
            saving.AccountNumber = "SAV-001";
            saving.InterestRate = 5;
            saving.Deposit(10000);
            saving.AddInterest();

            // Loan Account
            LoanAccount loan = new LoanAccount();
            loan.OwnerName = "Dara";
            loan.AccountNumber = "LOAN-001";
            loan.LoanAmount = 12000;
            loan.LoanMonths = 12;

            ViewBag.SavingOwner = saving.OwnerName;
            ViewBag.SavingBalance = saving.Balance;
            ViewBag.LoanOwner = loan.OwnerName;
            ViewBag.MonthlyPayment = loan.MonthlyPayment();

            return View();

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
