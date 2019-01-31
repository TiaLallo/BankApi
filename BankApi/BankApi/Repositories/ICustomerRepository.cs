using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    interface ICustomerRepository
    {
        Customer Create(Customer customer);
        List<Customer> Read();
        List<Account> Read(int CustomerId);
        Customer Update(Customer customer);
        Customer Delete(int id);
    }
}
