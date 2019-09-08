using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DBConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserLogin> User { get; set; }

        //public virtual ObjectResult<Customer> GetAllCustomers() {
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("GET_ALL_CUSTOMERS");
        //}

        //public virtual ObjectResult<Customer> GetEmployee()
        //{
        //    return this.Database.SqlQuery<Customer>("GetEmployee");
        //}
    }


}
