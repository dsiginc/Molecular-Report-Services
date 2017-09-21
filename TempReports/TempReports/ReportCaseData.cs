using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportCaseData
    {
        public ReportCaseData()
        {
            ReportCaseSpecimens = new List<ReportCaseSpecimens>();
            PrescribedDrugs = new List<PrescribedDrug>();
            NonPrescribedDrugs = new List<PrescribedDrug>();
            PrescribedDrugsNegative = new List<PrescribedDrug>();
            ValidityTestResults = new List<PrescribedDrug>();
        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public List<PrescribedDrug> ValidityTestResults { get; set; }
        public string PrescribedMedications { get; set; }
        public ReportCaseOrder ReportCaseOrder { get; set; }
        public ReportPhysicianInfo ReportPhysicianInfo { get; set; }
        public List<ReportCaseSpecimens> ReportCaseSpecimens { get; set; }
        public List<PrescribedDrug> PrescribedDrugs { get; set; }
        public List<PrescribedDrug> NonPrescribedDrugs { get; set; }

        public ReportPatient ReportPatient { get; set; }

        public List<PrescribedDrug> PrescribedDrugsNegative { get; set; }
    }
}
