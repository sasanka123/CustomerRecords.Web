using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.Entity
{
    public class UserCustomer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
