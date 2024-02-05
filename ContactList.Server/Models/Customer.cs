using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Server.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public ICollection<Attempt> Attempts { get; set; }


    }
}
