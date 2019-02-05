using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Repositories;
using BankApi.Models;

namespace BankApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account Create(Account account)
        {
            return _accountRepository.Create(account);
        }

        public void Delete(string IBAN)
        {
            _accountRepository.Delete(IBAN);
        }

        public List<Account> Read()
        {
            return _accountRepository.Read();
        }

        public Account Read(string IBAN)
        {
            return _accountRepository.Read(IBAN);
        }

        public Account Update(string IBAN, Account account)
        {
            var savedAccount = _accountRepository.Read(IBAN);
            if (savedAccount == null)
            {
                throw new Exception("Account not found");
            }
            else
            {
                return _accountRepository.Update(IBAN, account);
            }

        }
    }
}
