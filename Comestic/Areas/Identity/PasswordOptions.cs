using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comestic.Areas.Identity
{
    public class PasswordOptions
    {
        public int RequiredLength { get; set; } = 6;
        public int RequiredUniqueChars { get; set; } = 1;

        public bool RequiredNonAlphanummeric { get; set; } = true;
        public bool RequiredLowercase { get; set; } = true;
        public bool RequiredUppercase { get; set; } = true;
        public bool RequiredDigit { get; set; } = true;



    }
}
