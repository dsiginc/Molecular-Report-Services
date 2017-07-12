using System;

namespace ReportGenerator
{
    public class ReagentDetailsDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Vendor { get; set; }
        public string Catalog { get; set; }
        public string ReagentType { get; set; }
        public double QuantityAvailable { get; set; }
        public double QuantityNeededReaction { get; set; }
        public double TotalQuantityNeeded { get; set; }
        public long NumberOfReplicates { get; set; }
        public DateTime ExpirationDate { get; set; }

        public long RunId { get; set; }
        public long RunWorksheetId { get; set; }
        public bool InsufficientQuantity { get; set; }
        public bool IsMasterMix { get; set; }
        public bool AddedToMasterMix { get; set; }

        public bool IsCallibrator { get; set; }

        public string QuantityAvailableWithUnits { get; set; }
        public string QuantityNeededReactionWithUnits { get; set; }
        public string TotalQuantityNeededWithUnits { get; set; }
        public string Units { get; set; }
    }
}
