using System;
using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{

    public class FaxReportQueue
    {
        public long CaseId { get; set; }
        public string SentToFax { get; set; }
        public string Recepient { get; set; }
        public bool IsFaxed { get; set; }
        public DateTime? DateFaxed { get; set; }
        public DateTime DateRequested { get; set; }
        public string CaseNumber { get; set; }
        public string PatientName { get; set; }
        public bool IsProcessed { get; set; }
        public string ErrorMessage { get; set; }
        public int? FaxSentId { get; set; }
        public string FaxSentStatus { get; set; }
        public string LabClientName { get; set; }
        public string PreferredLabName { get; set; }
        public long? CaseTestId { get; set; }
        public bool IsPreAuth { get; set; }
        public long? InsuranceDetailsId { get; set; }
        public long CaseInfoId { get; set; }
        public long DocumentId { get; set; }
        public string CoverSheet { get; set; }
        public string FromLabName { get; set; }
        public string LabPhone { get; set; }
    }
}
