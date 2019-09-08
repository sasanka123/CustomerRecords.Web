using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.Entity
{
   public class Common
    {
        public List<Customer> Customers { get; set; }
        public List<Country> Countries { get; set; }
        public Country SelectedCountry { get; set; }
    }
}
