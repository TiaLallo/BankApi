using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Services
{
    interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction, int customerId);
        List<Transaction> Read(int IBAN);
    }
}
