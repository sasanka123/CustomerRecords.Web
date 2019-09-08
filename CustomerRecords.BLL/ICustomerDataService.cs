﻿using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.BLL
{
    public interface ICustomerDataService
    {
        List<Customer> Get();
        void Add(Customer customer);
        Customer Get(int id);
        void Remove(Customer customer);
    }
}
