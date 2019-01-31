using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    interface IAccountRepository
    {
        AccountRepository Create(AccountRepository account);
        List<AccountRepository> Read();
        AccountRepository Delete(AccountRepository account);
    }
}
