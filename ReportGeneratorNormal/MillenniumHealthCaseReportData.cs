using System.Collections.Generic;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class MillenniumHealthCaseReportData
    {
        public MillenniumHealthCaseReportData()
        {

        }

        public string PatientName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string MRN { get; set; }
        public string SSN { get; set; }
        /*----CaseInfo---start--*/
        public string SpecimenID { get; set; }
        public string AccessionID { get; set; }//caseNo
        public string OrderingPhysician { get; set; }
        public string SpecimenType { get; set; }
        public string LabClientName { get; set; }
        public string LabClientAddress { get; set; }
        public string AnatomicLocation { get; set; }//Specimen source
        public string DateReceived { get; set; }
        public string DateCollected { get; set; }
        public string DateSigned { get; set; }//Report Date
        /*----CaseInfo---end--*/

        //Results Summary -- Will find more details on how to create it
        //Test Results - Will hard the tables on the report with the test names but need to find a way to set on the report.
    }
}
