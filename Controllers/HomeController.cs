using System.Diagnostics;
using ACLEDABank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ACLEDABank.Controllers
{
    public class HomeController : Controller
    {
        // Database connection
        private readonly ACLEDABankContext _db;

        // Constructor - inject database
        public HomeController(ACLEDABankContext db)
        {
            _db = db;
        }
        // Show all accounts FROM DATABASE!
        public IActionResult Index()
        {
            var accounts = _db.BankAccounts.ToList();
            return View(accounts);
        }

        public IActionResult About()
        {
            return View();
        }

        // GET - Show empty form
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(BankAccount account)
        {
            _db.BankAccounts.Add(account);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // Get account by ID using Stored Procedure
        public IActionResult Details(int id)
        {
            var account = _db.BankAccounts
                .FromSqlRaw("EXEC SP_GetAccountByID @p0", id)
                .AsEnumerable()
                .FirstOrDefault();

            if (account == null)
                return NotFound();

            return View(account);
        }

        // Delete using Stored Procedure
        public IActionResult Delete(int id)
        {
            _db.Database
                .ExecuteSqlRaw("EXEC SP_DeleteAccount @p0", id);
            return RedirectToAction("Index");
        }
    }
}
