using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class CaseTestData
    {

        public bool SpecimenRejected { get; set; }

        public string ReasonForRejection { get; set; }

        public bool SpecimenRejectionOveridden { get; set; }

        public string ReasonForOverridden { get; set; }

        public string DateSigned { get; set; }

        public string DateCompleted { get; set; }

        public string Icd { get; set; }

        public string Cpt { get; set; }

        public string Loinc { get; set; }

        public string ResultSummary { get; set; }
     
        public int RepeatSequence { get; set; }
       
        public string TestName { get; set; }
       
        public string Code { get; set; }
      
        public string Status { get; set; }
      
        public string Result { get; set; }
      
      
        public string Pathologist { get; set; }

        public string Interpretation { get; set; }

        public string Methodology { get; set; }

        public string References { get; set; }

        public string Background { get; set; }

        public byte[] PathologistSignature { get; set; }
    }
}
