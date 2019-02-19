using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    public interface IAccountRepository
    {
        Account Create(Account account);
        List<Account> ReadBanksAccs(long bankId);
        void Delete(string IBAN);
        Account Update(string IBAN, Account account);
    }
}
