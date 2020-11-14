using GeoMed.Model.Account;
using GeoMed.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoMed.Model.Setting
{
    public class Specialization : BaseModel   // optional ممكن نشيلو  
    {
        public string Name { get; set; }

        public ICollection<GMUser> GMUsers { get; set; }
    }
}
