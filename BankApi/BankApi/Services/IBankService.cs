using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Services
{
    public interface IBankService
    {
        Bank CreateBank(Bank bank);
        List<Bank> Read();
        Bank Read(int id);
        Bank Update(Bank bank, int id);
        void Delete(int id);
    }
}
