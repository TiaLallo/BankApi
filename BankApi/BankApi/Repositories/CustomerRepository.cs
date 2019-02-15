using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;
using BankApi.Utilities;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public void Delete(int id)
        {
            var customer = Read(id);
            _context.Remove(customer);
            _context.SaveChanges();
            return;
        }

        public List<Customer> Read()
        {
            return _context.Customer
                .ToList();
        }

        public Customer Read(int id)
        {
            return _context.Customer
                .Include(p => p.Account)
                .FirstOrDefault(c => c.Id == id);
        }

        public Customer Update(int id, Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer UpdatePsw(int id, string newPsw)
        {
            var personChanging = Read(id);
            newPsw = PasswordHasher.HashPassword(newPsw);
            personChanging.Password = newPsw;
            _context.Customer.Update(personChanging);
            _context.SaveChanges();
            return personChanging;
        }
    }
}
