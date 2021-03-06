﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Services
{
    public interface IAccountService
    {
        Account CreateAccount(Account account);
        List<Account> Read();
        Account Read(string IBAN);
        Account Update(string IBAN, Account account);
        void Delete(string IBAN);
    }
}
