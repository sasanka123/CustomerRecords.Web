using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerRecords.DAL;
using CustomerRecords.Entity;

namespace CustomerRecords.BLL
{
    public class UserDataService : IUserDataService
    {
        private readonly IUserDataRepository userDataRepository;

        public UserDataService(IUserDataRepository userDataRepository)
        {
            this.userDataRepository = userDataRepository;
        }
        public UserLogin UserLogin(UserLogin model)
        {
            return userDataRepository.UserLogin(model);
        }
    }
}
