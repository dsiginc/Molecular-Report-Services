using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class CaseTestData
    {

        public bool SpecimenRejected { get; set; }

        public string ReasonForRejection { get; set; }

        public bool SpecimenRejectionOveridden { get; set; }

        public string ReasonForOverridden { get; set; }

        public long PathologistId { get; set; }

        public DateTime? DateSigned { get; set; }

        public DateTime? DateCompleted { get; set; }

        public string Icd { get; set; }

        public string Cpt { get; set; }

        public string Loinc { get; set; }

        public long StatusId { get; set; }

        public bool Stat { get; set; }

     
        public string ResultSummary { get; set; }
     
        public int RepeatSequence { get; set; }
       
        public string TestName { get; set; }
       
        public string Code { get; set; }
      
        public string Status { get; set; }
      
        public string Result { get; set; }
      
        public bool StatStatus { get; set; }
       
        public string SpecimenNumber { get; set; }
       
        public bool Repeated { get; set; }
        



    }
}
