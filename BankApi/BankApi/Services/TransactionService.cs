using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;
using BankApi.Repositories;

namespace BankApi.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Transaction CreateTransaction(Transaction transaction, int CustomerId)
        {
            return _transactionRepository.Create(transaction, CustomerId);
        }

        public List<Transaction> Read(int IBAN)
        {
            return _transactionRepository.Read(IBAN);
        }
    }
}
