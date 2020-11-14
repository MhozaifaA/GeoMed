using GeoMed.Model.Share;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GeoMed.Model.Account
{
    public class GMUser : IdentityUser<int>
    {
        public GMUser()
        {
            UserAreaJobs = new HashSet<UserAreaJob>();
        }
        public DateTime DeleteDate { get; set; }

        public int Gender { get; set; }  // enum (Gender)

        public int UserType { get; set; }  // enum(UserTypes)

        public DateTime BirthDate { get; set; }

       public ICollection<UserAreaJob> UserAreaJobs { get; set; }

    }
}
