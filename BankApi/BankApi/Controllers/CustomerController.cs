using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankApi.Services;
using BankApi.Models;
using BankApi.Repositories;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // id
        [HttpGet ("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return new JsonResult(_customerService.Read(id));
        }

        // GET: api/Customer/5
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            return new JsonResult(_customerService.Read());
        }

        // POST: api/Customer
        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            return _customerService.CreateCustomer(customer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, Customer customer)
        {
            return _customerService.Update(id, customer);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _customerService.Delete(id);
            return new NoContentResult();
        }
    }
}
