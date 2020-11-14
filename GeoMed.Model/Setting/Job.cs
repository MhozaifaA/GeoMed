using GeoMed.Model.Base;
using GeoMed.Model.Share;
using System;
using System.Collections.Generic;
namespace GeoMed.Model.Setting
{
   public class Job : BaseModel
    {
        public Job()
        {
            UserAreaJobs = new HashSet<UserAreaJob>();
        }
        public string Name { get; set; }
      
        public ICollection<UserAreaJob> UserAreaJobs { get; set; }
    }
}
