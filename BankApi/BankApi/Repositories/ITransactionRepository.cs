using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Repositories
{
    interface ITransactionRepository
    {
        Transaction Create(Transaction transaction, int CustomerId);
        List<Transaction> Read(int CustomerId);
    }
}
