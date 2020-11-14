using GeoMed.Model.Account;
using GeoMed.Model.Setting;
using GeoMed.Model.Share;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GeoMed.SqlServer
{
    public class GMContext  : IdentityDbContext<GMUser ,GMRole , int,GMUserClaim ,
        GMUserRoles,GMUserLogin ,GMRoleClaim,GMUserToken>   
    {
        public GMContext(DbContextOptions<GMContext> options)
            : base(options)
        {

        }

        public DbSet<Area> Areas { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Specialization> Specializations { get; set; }

        public DbSet<UserAreaJob> UserAreaJobs { get; set; }
    }
}
