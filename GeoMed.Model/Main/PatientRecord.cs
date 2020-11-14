using GeoMed.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMed.Model.Main
{
    public class PatientRecord  : BaseModel
    {
        [Column(TypeName = "nvarchar(100)")]
        public string MainComplaint { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EntranceDate { get; set; }

        
    }
}
