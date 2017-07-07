using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public partial class QuantitativeResults
    {

        public long Id { get; set; }

        public long RunProductId { get; set; }

        public long TestResultDataInfoId { get; set; }

        public double TestResult { get; set; }

        public string DataPointName { get; set; }

        public long RunId { get; set; }

        public long CalculationOrder { get; set; }

        public long CaseTestId { get; set; }

        public long ReplicateNumber { get; set; }

        public bool IsCallibrator { get; set; }
    }
}
