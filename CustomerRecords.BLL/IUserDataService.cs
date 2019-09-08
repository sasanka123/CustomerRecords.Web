using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.BLL
{
  public  interface IUserDataService
    {
        UserLogin UserLogin(UserLogin model);
    }
}
