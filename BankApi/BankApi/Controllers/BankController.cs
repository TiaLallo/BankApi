using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankApi.Repositories;
using BankApi.Services;
using BankApi.Models;

namespace BankApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankRepository _bankRepository;
        private readonly IBankService _bankService;

        public BankController(IBankRepository bankRepo, IBankService bankService)
        {
            _bankRepository = bankRepo;
            _bankService = bankService;
        }

        //GET api/banks
        [HttpGet]
        public ActionResult GetAllBanks()
        {
            return new JsonResult(_bankService.Read());
        }

        // POST: api/banks
        [HttpPost]
        public ActionResult<Bank> CreateBank(Bank bank)
        {
            var newBank = _bankService.CreateBank(bank);
            return newBank;
        }

        //Delete: api/banks/1
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _bankService.Delete(id);
            return new NoContentResult();
        }
    }
}