using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.DAL
{
   public interface IUserDataRepository
    {
        UserLogin UserLogin(UserLogin model);
    }
}
