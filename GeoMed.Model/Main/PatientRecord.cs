using GeoMed.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMed.Model.Main
{
    public class PatientRecord  : BaseModel
    {
        public string MainComplaint { get; set; }

        public DateTime EntranceDate { get; set; }

        
    }
}
