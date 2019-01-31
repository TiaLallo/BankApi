using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Repositories
{
    interface ITransactionRepository
    {
        TransactionRepository Create(TransactionRepository transaction);
        List<TransactionRepository> Read();
    }
}
