using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction Create(Transaction transaction, int CustomerId)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> Read(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}
