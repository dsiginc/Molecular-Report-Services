using System.Collections.Generic;

namespace Molecular.DataAccess.ReportsService
{
    public class LabOrdersReport
    {
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public List<LabOrderReport> LabOrders { get; set; }
    }
}
