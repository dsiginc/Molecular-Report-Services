using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class CaseData
    {

        public long Id { get; set; }

        public string CaseNo { get; set; }

        public long? Status { get; set; }

        public string OrderNo { get; set; }

        public string CaseComments { get; set; }


        public DateTime? OrderDate { get; set; }

        public string ClinicalHistory { get; set; }

        public string IcdCodes { get; set; }

        public string SpecimenType { get; set; }

        public string SpecimenSource { get; set; }

        public string SpecimenNumber { get; set; }
        public string StatusName { get; set; }

        public string PhysicianName { get; set; }


        public string TestTypeName { get; set; }


        public string PatientName { get; set; }


        public DateTime? DateOfBirth { get; set; }


        public long PatientId { get; set; }


        public string CaseStatus { get; set; }


        public string SecondaryPhysicianname { get; set; }
    }
}
