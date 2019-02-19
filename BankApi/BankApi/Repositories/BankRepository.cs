using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(bank);
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
                .Include(p=> p.Customer)
                .ToList();
        }

        public Bank Read(int id)
        {
            return _context.Bank
                .Include(p=> p.Customer)
                .FirstOrDefault(b => b.Id == id);
        }

        public Bank Update(Bank bank, int id)
        {
            _context.Update(bank);
            _context.SaveChanges();
            return bank;
        }

        public List<Customer> GetBankCustomers(long bank)
        {
            return _context.Customer.Where(p => p.BankId == bank).ToList();
        }
    }
}
