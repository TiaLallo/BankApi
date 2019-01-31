using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    interface IBankRepository
    {
        Bank Create(Bank bank);
        List<Bank> Read();
        Bank Read(int id);
        Bank Update(Bank bank);
        Bank Delete(Bank bank);
    }
}
