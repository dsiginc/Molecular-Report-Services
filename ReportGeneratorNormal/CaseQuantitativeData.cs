using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class CaseQuantitativeData
    {

        public CaseQuantitativeData()
        {
            CaseInfo = new CaseData();
            CaseTestInfo = new CaseTestData();
            PatientInfo = new PatientInfoData();
            SpecimenInfo = new SpecimenInfoData();
            QuantitativeData = new List<QuantitativeResults>();

        }
        public CaseData CaseInfo { get; set; }

        public CaseTestData CaseTestInfo { get; set; }

        public PatientInfoData PatientInfo { get; set; }

        public SpecimenInfoData SpecimenInfo { get; set; }

        public List<QuantitativeResults> QuantitativeData { get; set; }


    }

}
