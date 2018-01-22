using System;
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
            ReportSummary = new List<PrescribedDrug>();
            IsomerResults = new List<PrescribedDrug>();
        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string BillingLabInfo { get; set; }
        public string ProcessingLabInfo { get; set; }
        public string ApprovedBy { get; set; }
        public List<PrescribedDrug> ValidityTestResults { get; set; }
        public string PrescribedMedications { get; set; }
        public ReportCaseOrder ReportCaseOrder { get; set; }
        public ReportPhysicianInfo ReportPhysicianInfo { get; set; }
        public List<ReportCaseSpecimens> ReportCaseSpecimens { get; set; }
        public List<PrescribedDrug> PrescribedDrugs { get; set; }
        public List<PrescribedDrug> NonPrescribedDrugs { get; set; }
        public List<PrescribedDrug> ReportSummary { get; set; }
        public ReportPatient ReportPatient { get; set; }
        public List<PrescribedDrug> IsomerResults { get; set; }
        public List<PrescribedDrug> PrescribedDrugsNegative { get; set; }

        public string TemplateName { get; set; }
        public bool ShowValidityResults { get; set; }
        public bool ShowIsomerResults { get; set; }
        public string AmendReason { get; set; }
        public DateTime? DateAmended { get; set; }
        public string OrginalCaseNumber { get; set; }
        public bool IsCancelled { get; set; }
        public string CancellationReason { get; set; }

        public bool IsAmended { get; set; }

        public string AmendmentLabel { get; set; }
    }
}
