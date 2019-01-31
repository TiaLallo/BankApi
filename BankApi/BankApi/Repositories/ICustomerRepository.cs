using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    interface ICustomerRepository
    {
        CustomerRepository Create(CustomerRepository customer);
        List<CustomerRepository> Read();
        CustomerRepository Update(CustomerRepository customer);
        CustomerRepository Delete(int id);
    }
}
