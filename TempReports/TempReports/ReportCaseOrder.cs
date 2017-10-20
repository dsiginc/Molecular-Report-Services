using System;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportCaseOrder
    {
        public long Id { get; set; }
        public long Version { get; set; }
        public long LabId { get; set; }
        public string AmendedCaseOrderid { get; set; }
        public string CancelCaseReason { get; set; }
        public string CaseNo { get; set; }
        public string ClinicalIcd { get; set; }
        public string ClinicalHistory { get; set; }
        public string CaseType { get; set; }
        public string ClaimNo { get; set; }
        public string DateReceived { get; set; }

        public string DateCollected { get; set; }
        public string TimeReceived { get; set; }
        public string FinalInterpretation { get; set; }
        public string FinalizedDate { get; set; }
        public string FinalizedTime { get; set; }
        public string InjuryDate { get; set; }
        public string InjuryTime { get; set; }
        public string InsuranceType { get; set; }
        public bool IsAmended { get; set; }
        public bool IsCorrection { get; set; }
        public bool IsRevision { get; set; }
        public string LoggedInBy { get; set; }
        public string MedRecNo { get; set; }
        public bool? ShowOnReport { get; set; }
        public bool? FinalReportViewed { get; set; }
        public bool? IsPrinted { get; set; }
        public string Volume { get; set; }
        public string CancelledBy { get; set; }
        public string CancelledDate { get; set; }
        public string CancelledTime { get; set; }
        public bool? IsAutoSignout { get; set; }
        public string PhysicianLocation { get; set; }
        public string PatientName { get; set; }
        public string PathologistName { get; set; }
        public long PhysicianId { get; set; }
        public string PhysicianName { get; set; }
        public string SecondaryPhysician { get; set; }
        public string ProfileName { get; set; }
        public long PatientId { get; set; }
    }
}
