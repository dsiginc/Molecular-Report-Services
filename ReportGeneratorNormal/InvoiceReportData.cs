
using System;

namespace Molecular.DataAccess.ReportsService
{
    public class InvoiceReportData
    {
        public string FromLabAddress { get; set; }
        public string ToClientAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public long NumberOfSpecimens { get; set; }
        public decimal PricePerSpecimen { get; set; }
    }
}
