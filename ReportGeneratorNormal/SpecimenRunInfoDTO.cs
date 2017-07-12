using System;

namespace ReportGenerator
{
    public class SpecimenRunInfoDTO
    {
        public long CaseTestWorklistId { get; set; }
        public long StatusId { get; set; }
        public long CaseId { get; set; }
        public string CaseNumber { get; set; }
        public long SpecId { get; set; }
        public string PatientName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime OrderDate { get; set; }
        public string SpecimenId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public double? QuantityAvailable { get; set; }
        public DateTime NaExtractionDate { get; set; }
        public double? QuantityNeeded { get; set; }
        public double? TotalQuantityNeeded { get; set; }
        public int NumberOfReplicates { get; set; }
        public string Status { get; set; }
        public bool Stat { get; set; }

        public bool IsSelected { get; set; }
        public bool InsufficientQuantity { get; set; }

        public string QuantityAvailableWithUnits { get; set; }
        public string QuantityNeededWithUnits { get; set; }
        public string TotalQuantityNeededWithUnits { get; set; }

        public long CaseTestId { get; set; }

        public string Units { get; set; }
    }
}
