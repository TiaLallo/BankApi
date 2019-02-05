using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    interface ITransactionRepository
    {
        TransactionRepository Create(Transaction transaction);
        List<Transaction> Read(int IBAN);
    }
}
