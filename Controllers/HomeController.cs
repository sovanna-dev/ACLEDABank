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
            List<BankAccount> accounts = new List<BankAccount>()
            {
                new BankAccount { OwnerName="Sovanna", AccountNumber= "ACC-001", Balance= 5000 },
                new BankAccount { OwnerName= "Dara" , AccountNumber = "ACC-002", Balance= 3200 },
                new BankAccount { OwnerName = "Sreymom",  AccountNumber = "ACC-003", Balance = 8750 },
                new BankAccount { OwnerName = "Piseth",   AccountNumber = "ACC-004", Balance = 1500 },
            };

            return View(accounts);
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
