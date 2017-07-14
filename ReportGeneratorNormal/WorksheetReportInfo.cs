using System.Collections.Generic;

namespace ReportGenerator
{
    public class WorksheetReportInfo
    {
        public WorksheetReportInfo()
        {

        }
        public string Template { get; set; }
        public string WorklistName { get; set; }
        public long RunId { get; set; }
        public bool TestWorksheetAccepted { get; set; }
        public int NumberOfSpecimenReplicates { get; set; }
        public int NumberOfStandardReplicates { get; set; }
        public long NumberOfControlReplicates { get; set; }
        public long NumberOfCasesForTest { get; set; }
        public long NumberOfControlsForTest { get; set; }
        public int NumberOfReactionsForTest { get; set; }
        public List<ReagentDetailsDTO> ReagentsForTest { get; set; }
        public List<ReagentDetailsDTO> ControlsForTest { get; set; }
        public List<SpecimenRunInfoDTO> SpecimensForTest { get; set; }
        public long NumberOfCasesForStandard { get; set; }
        public long NumberOfControlsForStandard { get; set; }
        public int NumberOfReactionsForStandard { get; set; }
        public List<ReagentDetailsDTO> ReagentsForStandard { get; set; }
        public List<ReagentDetailsDTO> ControlsForStandard { get; set; }
        public List<SpecimenRunInfoDTO> SpecimensForStandard { get; set; }
    }
}
