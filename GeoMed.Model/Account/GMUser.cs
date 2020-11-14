using GeoMed.Model.Share;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoMed.Model.Account
{
    public class GMUser : IdentityUser<int>
    {
        public GMUser()
        {
            UserAreaJobs = new HashSet<UserAreaJob>();
        }
        [Column(TypeName = "datetime2")]
        public DateTime DeleteDate { get; set; }

        [Column(TypeName = "int")]
        public int Gender { get; set; }  // enum (Gender)

        [Column(TypeName = "int")]
        public int UserType { get; set; }  // enum(UserTypes)

        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

       public ICollection<UserAreaJob> UserAreaJobs { get; set; }

    }
}
