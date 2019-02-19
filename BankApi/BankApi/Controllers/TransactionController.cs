using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankApi.Services;
using BankApi.Models;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService  transactionService)
        {
            _transactionService = transactionService;
        }

        // GET: api/Transactions
        [HttpGet]
        public ActionResult<List<Transaction>> GetTransactions(int IBAN)
        {
            return new JsonResult(_transactionService.Read(IBAN));
        }

        [HttpPost]
        public ActionResult<Transaction> Post(Transaction transaction, int customerId)
        {
            return _transactionService.CreateTransaction(transaction, customerId);
        }

    }
}
