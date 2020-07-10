using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comestic.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
       
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }

        public string City { get; set; }
       
        public string Distric { get; set; }
       
        public string StreetAdress { get; set; }
    }
}
