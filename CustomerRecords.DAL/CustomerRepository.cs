using CustomerRecords.DAL;
using CustomerRecords.DAL.Data;
using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.DAL
{
    public class CustomerRepository : IRepository<Customer>
    {

        private readonly DataContext dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Customer> Get()
        {
            //************************CALL FROM SP
            var data = dataContext.Database.SqlQuery<UserCustomer>("GET_USER_CUSTOMER");
            var list = data.ToList<UserCustomer>();

            var userList = dataContext.Customers;
            return userList.ToList();
        }

        public void Remove(Customer entity)
        {
            var customer = dataContext.Customers.Where(x => x.Id == entity.Id).FirstOrDefault();
            dataContext.Customers.Remove(customer);
            dataContext.SaveChanges();
        }

        public void Add(Customer customer)
        {
            var id = customer.Id;
            dataContext.Customers.AddOrUpdate(customer);
            dataContext.SaveChanges();
        }

        public Customer Get(int id)
        {
            return dataContext.Customers.Where(x => x.Id == id).FirstOrDefault();
        }

       
    }
}
