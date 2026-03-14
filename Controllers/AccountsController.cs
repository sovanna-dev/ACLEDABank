using ACLEDABank.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACLEDABank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ACLEDABankContext _db;
        public AccountsController(ACLEDABankContext db)
        { 
            _db = db;
        }

        // GET: api/accounts
        [HttpGet]
        public IActionResult GetAll()
        { 
            var accounts = _db.BankAccounts.ToList();
            return Ok(accounts);
        }

        // GET: api/accounts/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var account = _db.BankAccounts.Find(id);
            if (account == null)
                return NotFound(new
                {
                    message = "Account not found!"
                });
            return Ok(account);
        }

        //POST: api/accounts
        public IActionResult Create([FromBody] BankAccount account)
        {
            if (account == null)
                return BadRequest();
            _db.BankAccounts.Add(account);
            _db.SaveChanges();

            return CreatedAtAction(
                nameof(GetById),
                new { id = account.ID },
                account
            );

        }

        //PUT: api/accounts/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BankAccount updated)
        {
            var account = _db.BankAccounts.Find(id);
            if (account == null)
                return BadRequest();
            account.OwnerName = updated.OwnerName;
            account.AccountNumber = updated.AccountNumber;
            account.Balance = updated.Balance;

            _db.SaveChanges();
            return Ok(account);
        }

        // DELETE: api/accounts/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var account = _db.BankAccounts.Find(id);
            if (account == null)
                return BadRequest();
            _db.BankAccounts.Remove(account);
            _db.SaveChanges();

            return Ok(new
            {
                message = "Account deleted!"
            });
        }

    }
}
