using System;
using System.Collections.Generic;
using System.Text;

namespace BraspagTest.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public string Identity { get; set; }

        public string IdentityType { get; set; }

        public string Email { get; set; }

        public string Birthdate { get; set; }

        public Address Address { get; set; }

        public Address DeliveryAddress { get; set; }
    }
}
