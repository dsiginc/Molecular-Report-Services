using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportCaseData
    {
        public ReportCaseData()
        {
            ReportCaseSpecimens = new List<ReportCaseSpecimens>();
        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public ReportCaseOrder ReportCaseOrder { get; set; }
        public List<ReportCaseSpecimens> ReportCaseSpecimens { get; set; }
        public ReportPatient ReportPatient { get; set; }

    }
}
