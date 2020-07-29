namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportCaseResult
    {
        public long Id { get; set; }
        public long Version { get; set; }
        public long CaseOrderId { get; set; }
        public long CaseSpecimenId { get; set; }
        public long TestCodeId { get; set; }
        public string Comments { get; set; }
        public string Concetration { get; set; }
        public string ConfirmFlag { get; set; }
        public string Result { get; set; }
        public string Type { get; set; }
        public string Valuerange { get; set; }
        public bool IsReflexiveTest { get; set; }
        public string Compound { get; set; }
        public string CaseNo { get; set; }
        public long ProfileId { get; set; }
        public string Cutoff { get; set; }
        public string Class { get; set; }
        public bool ShowColor { get; set; }

        public string Compound1 { get; set; }
        public string Cutoff1 { get; set; }
        public string Compound2 { get; set; }
        public string Cutoff2 { get; set; }
        public string DetectionWindow { get; set; }

        public string Prescription { get; set; }
        public string Flag { get; set; }
        public bool InconsistentFlag { get; set; }
        public string Units { get; set; }
        public string ApplyColor { get; set; }
        public string ResultForScreens { get; set; }
    }
}
