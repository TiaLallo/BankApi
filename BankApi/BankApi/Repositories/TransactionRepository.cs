using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankdbContext _context;

        public TransactionRepository(BankdbContext context)
        {
            _context = context;
        }

        public Transaction Create(Transaction transaction, int CustomerId)
        {
            _context.Transaction.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }

        public List<Transaction> Read(int Iban)
        {
            return _context.Transaction.AsNoTracking().ToList();
        }
    }
}
