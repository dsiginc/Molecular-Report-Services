
using System;

namespace Molecular.DataAccess.ReportsService
{
    public class InvoiceReportData
    {
        public string FromLabAddress { get; set; }
        public string ToClientAddress { get; set; }
        public string TotalAmount { get; set; }
        public string NumberOfSpecimens { get; set; }
        public string PricePerSpecimen { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
