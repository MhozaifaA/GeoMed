using GeoMed.Model.Base;
using GeoMed.Model.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoMed.Model.Setting
{
   public class Job : BaseModel
    {
        public Job()
        {
            UserAreaJobs = new HashSet<UserAreaJob>();
        }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
      
        public ICollection<UserAreaJob> UserAreaJobs { get; set; }
    }
}
