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
            ReportSummaryNew = new List<PrescribedDrug>();
            IsomerResults = new List<PrescribedDrug>();
            PrescribedDrugsGroupBy = new List<PrescribedDrugList>();
            PrescribedDrugsNegativeGroupBy = new List<PrescribedDrugList>();
            PreviousHistoryChartData = new List<PreviousHistoryChartData>();
        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string BillingLabInfo { get; set; }
        public string LabCLIA { get; set; }
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
        public List<PrescribedDrug> ReportSummaryNew { get; set; }

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
        public string LabName { get; set; }
        public string SpecimenType { get; set; }

        public List<PrescribedDrugList> PrescribedDrugsGroupBy { get; set; }
        public List<PrescribedDrugList> PrescribedDrugsNegativeGroupBy { get; set; }
        public List<PreviousHistoryChartData> PreviousHistoryChartData { get; set; }
    }
    public class PrescribedDrugList
    {
        public PrescribedDrugList()
        {
            PrescribedDrugDataList = new List<PrescribedDrug>();
        }
        public List<PrescribedDrug> PrescribedDrugDataList { get; set; }
        public string Class { get; set; }
    }
    public class PreviousHistoryChartData
    {
        public string Name { get; set; }
        public string DateCollected { get; set; }
        public string Concentration { get; set; }
    }
}
