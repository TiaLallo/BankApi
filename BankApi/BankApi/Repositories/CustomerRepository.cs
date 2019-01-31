using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BankdbContext _context;

        public CustomerRepository(BankdbContext context)
        {
            _context = context;
        }

        public Customer Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Delete(int id)
        {
            var customer = Read(id);
            _context.Remove(customer);
            _context.SaveChanges();
            return 
        }

        public List<Customer> Read()
        {
            throw new NotImplementedException();
        }

        public List<Account> Read(int CustomerId)
        {
            return _context.Account
                .ToList();
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
