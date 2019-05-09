using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace VianorKyustendil.Data.Models
{
    // Add profile data for application users by adding properties to the VianorKyustendilUser class
    public class VianorKyustendilUser : IdentityUser
    {
        public VianorKyustendilUser()
        {
            this.Orders = new HashSet<Order>();
            this.Articles = new HashSet<Article>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; } = "Bulgaria";

        public string JobTitle { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
