using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class CustomerInformation
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public CustomerInformation()
        {
            
        }

        public CustomerInformation(int customerId, string lastName, string firstName, string phoneNumber, string email)
        {
            CustomerId = customerId;
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"{CustomerId}, {LastName}, {FirstName}, {PhoneNumber}, {Email}";
        }
    }
}
