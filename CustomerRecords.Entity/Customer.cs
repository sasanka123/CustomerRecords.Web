using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.Entity
{
    [Table("CUSTOMER_DETAILS")]
    public class Customer 
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "The Id is required")]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The First Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Invalid contact format.")]  
        public string ContactNo { get; set; }
    }
}
