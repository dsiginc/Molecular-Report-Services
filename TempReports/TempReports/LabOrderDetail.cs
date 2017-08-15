using System;

namespace Molecular.DataAccess.ReportsService
{
    public class LabOrderDetail
    {
        public long Id { get; set; }
        public bool IsTestPanel { get; set; }
        public string TestName { get; set; }
        public bool Stat { get; set; }
    }
}
