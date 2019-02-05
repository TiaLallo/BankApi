using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankdbContext _context;

        public AccountRepository(BankdbContext context)
        {
            _context = context;
        }

        public Account Create(Account account)
        {
            _context.Account.Add(account);
            _context.SaveChanges();
            return account;
        }

        public void Delete(string IBAN)
        {
            _context.Remove(IBAN);
            _context.SaveChanges();
            return; 
        }

        public List<Account> Read()
        {
            return _context.Account
                .Include(p => p.Transaction)
                .ToList();
        }

        public Account Update(string IBAN, Account account)
        {
            _context.Update(account);
            _context.SaveChanges();
            return account;
        }
    }
}
