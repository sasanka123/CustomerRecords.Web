using CustomerRecords.DAL.Data;
using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.DAL
{
   public class UserDataRepository :IUserDataRepository
    {
        private readonly DataContext dataContext;

        public UserDataRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public UserLogin UserLogin(UserLogin model)
        {
            var ssss = dataContext.User;
            return  dataContext.User.FirstOrDefault();
        }
    }
}
