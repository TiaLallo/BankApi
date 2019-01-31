using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankdbContext _context;

        public AccountRepository(BankdbContext context)
        {
            _context = context;
        }

        public AccountRepository Create(AccountRepository account)
        {
            throw new NotImplementedException();
        }

        public AccountRepository Delete(AccountRepository account)
        {
            throw new NotImplementedException();
        }

        public List<AccountRepository> Read()
        {
            return _context.Account
                .Include(p => p.Transaction)
                .ToList();
        }
    }
}
