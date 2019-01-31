using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{

    public class BankRepository : IBankRepository
    {
        private readonly BankdbContext _context;

        public BankRepository(BankdbContext context)
        {
            _context = context;
        }

        public Bank Create(Bank bank)
        {
            _context.Bank.Add(bank);
            _context.SaveChanges();
            return bank;
        }

        public Bank Delete(int id)
        {
            var bank = Read(id);
            _context.Bank.Remove(bank);
            _context.SaveChanges();
            return bank;
        }

        public List<Bank> Read()
        {
            return _context.Bank
                .ToList();
        }

        public Bank Read(int id)
        {
            return _context.Bank
                .FirstOrDefault(b => b.Id == id);
        }

        public Bank Update(Bank bank)
        {
            _context.Bank.Update(bank);
            _context.SaveChanges();
            return bank;
        }
    }
}
