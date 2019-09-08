using CustomerRecords.DAL;
using CustomerRecords.DAL.Data;
using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.BLL
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly CustomerRepository customerRepository;

        public CustomerDataService(CustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public List<Customer> Get()
        {
            return customerRepository.Get().ToList();
        }

        public Customer Get(int id)
        {
            return customerRepository.Get(id);
        }

        public void Add(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void Remove(Customer customer)
        {
            customerRepository.Remove(customer);
        }

       
    }
}
