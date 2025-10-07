using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        // Model representing a customer to store customer details
        public int Id { get; set; }

        [Required]  // Name is mandatory for identifying the customer
        public string Name { get; set; }

        [Required]  // Address is required for records and correspondence
        public string Address { get; set; }

        public string TelephoneNumber { get; set; }

        public string ContactPersonName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]  // Validate email format for contact person
        public string ContactPersonEmail { get; set; }

        public string VATNumber { get; set; }
    }
}