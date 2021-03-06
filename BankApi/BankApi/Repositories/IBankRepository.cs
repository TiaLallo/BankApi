﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.Models;

namespace BankApi.Repositories
{
    public interface IBankRepository
    {
        Bank Create(Bank bank);
        List<Bank> Read();
        Bank Read(int id);
        Bank Update(Bank bank, int id);
        Bank Delete(int id);
    }
}
