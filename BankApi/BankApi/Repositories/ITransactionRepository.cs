using BankApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Repositories
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction, int CustomerId);
        List<Transaction> Read(int IBAN);
    }
}
