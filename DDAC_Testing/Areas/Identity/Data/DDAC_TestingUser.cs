using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DDAC_Testing.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the DDAC_TestingUser class
    public class DDAC_TestingUser : IdentityUser
    {
        [PersonalData]
        public string CustomerFullName { get; set; }
        [PersonalData]
        public int CustomerAge { get; set; }
        [PersonalData]
        public string CustomerAddress { get; set; }
        [PersonalData]
        public DateTime CustomerDOB { get; set; }

    }
}
