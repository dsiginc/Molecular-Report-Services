using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportGenerator;

namespace ReportingService.WebApi.Controllers
{
    public class QuantitativeReportInfo
    {

        public QuantitativeReportInfo()
            {
            CaseQuantitativeData = new CaseQuantitativeData();
            }
        public string Template { get; set; }
        public CaseQuantitativeData CaseQuantitativeData { get; set; }
    }
}
