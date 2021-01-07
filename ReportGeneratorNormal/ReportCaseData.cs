using System;
using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportCaseData
    {
        public ReportCaseData()
        {
            ReportCaseSpecimens = new List<ReportCaseSpecimens>();
            UrineDrugReportCaseSpecimens = new List<ReportCaseSpecimens>();
            PrescribedDrugs = new List<PrescribedDrug>();
            NonPrescribedDrugs = new List<PrescribedDrug>();
            PrescribedDrugsNegative = new List<PrescribedDrug>();
            ValidityTestResults = new List<PrescribedDrug>();
            ValidityTestResultsSplit = new List<BasicCustomDDO>[4];
            ReportSummary = new List<PrescribedDrug>();
            ReportSummaryNew = new List<PrescribedDrug>();
            IsomerResults = new List<PrescribedDrug>();
            PreviousHistory = new PreviousHistory[8];
            PrescribedDrugsGroupBy = new List<PrescribedDrugList>();
            PrescribedDrugsNegativeGroupBy = new List<PrescribedDrugList>();
            PreviousHistoryChartData = new List<PreviousHistoryChartData>();
            PreviousHistoryExcelChartData = new List<PreviousHistory>();

            IsomerResultsNegative = new List<PrescribedDrug>();
            IsomerResultsPositive = new List<PrescribedDrug>();
            ImmunoassayScreenResults = new List<PrescribedDrug>();
        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string BillingLabInfo { get; set; }
        public string LabCLIA { get; set; }
        public string ProcessingLabInfo { get; set; }
        public string ApprovedBy { get; set; }
        public string PrescribedMedications { get; set; }
        public List<PrescribedDrug> ValidityTestResults { get; set; }
        public List<BasicCustomDDO>[] ValidityTestResultsSplit { get; set; }
        public ReportCaseOrder ReportCaseOrder { get; set; }
        public ReportPhysicianInfo ReportPhysicianInfo { get; set; }
        public List<ReportCaseSpecimens> ReportCaseSpecimens { get; set; }
        public List<ReportCaseSpecimens> UrineDrugReportCaseSpecimens { get; set; }
        public List<PrescribedDrug> PrescribedDrugs { get; set; }
        public List<PrescribedDrug> NonPrescribedDrugs { get; set; }

        public List<PrescribedDrug> ReportSummary { get; set; }
        public List<PrescribedDrug> ReportSummaryNew { get; set; }
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
        public string LabName { get; set; }
        public string SpecimenType { get; set; }
        public string SpecimenId { get; set; }
        public string LabMedicalDirector { get; set; }
        public string LabClientName { get; set; }
        public string LabClientAddress { get; set; }
        public string EMRReference { get; set; }
        public List<ToxLabOrderDetail> LabOrderDetails { get; set; }
        public ToxLabOrderReportData LabOrderReport { get; set; }
        public byte[] LabLogo { get; set; }
        public PreviousHistory[] PreviousHistory { get; set; }
        public int PreviousCasesCount { get; set; }
        public string ReportStatus { get; set; }
        public bool ValidityPassed { get; set; }
        public List<PrescribedDrugList> PrescribedDrugsGroupBy { get; set; }
        public List<PrescribedDrugList> PrescribedDrugsNegativeGroupBy { get; set; }
        public List<PreviousHistoryChartData> PreviousHistoryChartData { get; set; }
        public bool PreviousHistoryExists { get; set; }
        public bool ScreenResultsExists { get; set; }
        public bool ShowPresDrugsNegative { get; set; }
        public bool ShowPresDrugsPositive { get; set; }
        public bool ShowNonPresDrugsPositive { get; set; }
        public byte[] ChartData { get; set; }
        public List<PreviousHistory> PreviousHistoryExcelChartData { get; set; }
        public List<BasicCustomDDO>[] ScreenResultsSplit { get; set; }
        public bool ShowScreenResults { get; set; }
        public string ValidityComment { get; set; }
        public string ValidityFlag { get; set; }
        public string ConfirmedAnalytes { get; set; }
        public List<BasicCustomDDO>[] ScreensSplit { get; set; }
        public List<ReportCaseResult> ReportCaseResultsWithNoGroup { get; set; }

        public List<PrescribedDrug> IsomerResultsNegative { get; set; }
        public List<PrescribedDrug> IsomerResultsPositive { get; set; }
        public bool ShowIsomerResultsNegative { get; set; }
        public bool ShowIsomerResultsPositive { get; set; }
        public List<PrescribedDrug> ImmunoassayScreenResults { get; set; }
    }
    public class PreviousHistory
    {
        public string Name { get; set; }
        public string ValuePrev1 { get; set; }
        public string ValuePrev2 { get; set; }
        public string ValuePrev3 { get; set; }
        public string ValuePrev4 { get; set; }
        public string ValuePrev5 { get; set; }
        public string ValuePrev6 { get; set; }
        public string ValuePrev7 { get; set; }
        public string ValuePrev8 { get; set; }
        public string ValuePrev9 { get; set; }
        public string ValuePrev10 { get; set; }
        public string ValuePrev11 { get; set; }
        public string ValuePrev12 { get; set; }
        public string ValuePrev13 { get; set; }
        public string ValuePrev14 { get; set; }
        public string ValuePrev15 { get; set; }
        public string ValuePrev16 { get; set; }
        public string ValuePrev17 { get; set; }
        public string ValuePrev18 { get; set; }
        public string ValuePrev19 { get; set; }
        public string ValuePrev20 { get; set; }
        public string ValuePrev21 { get; set; }
        public string ValuePrev22 { get; set; }
        public string ValuePrev23 { get; set; }
        public string ValuePrev24 { get; set; }
        public string ValuePrev25 { get; set; }
        public string ValuePrev26 { get; set; }
        public string ShowColor { get; set; }
        public string Class { get; set; }
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


        public double Value { get; set; }
        public DateTime DateBiopsy { get; set; }
    }
}
