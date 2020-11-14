using GeoMed.Model.Account;
using GeoMed.Model.Base;
using GeoMed.Model.Setting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoMed.Model.Share
{
    public class UserAreaJob : BaseModel
    {
        public int UserId { get; set; }

        public GMUser GMUser { get; set; }

        public int JobId { get; set; }

        public Job Job { get; set; }

        public int AreaId { get; set; }

        public Area Area { get; set; }
    }
}
