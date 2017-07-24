using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class CaseSequenceData
    {

        public CaseSequenceData()
        {
            CaseInfo = new CaseData();
            CaseTestInfo = new CaseTestData();
            PatientInfo = new PatientInfoData();
            SpecimenInfo = new SpecimenInfoData();
            VariantsInfo = new List<VariantsData>();

        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public CaseData CaseInfo { get; set; }

        public CaseTestData CaseTestInfo { get; set; }

        public PatientInfoData PatientInfo { get; set; }

        public SpecimenInfoData SpecimenInfo { get; set; }

        public List<VariantsData> VariantsInfo { get; set; }

       
    }

 
}
