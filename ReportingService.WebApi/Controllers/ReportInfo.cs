using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportGenerator;

namespace ReportingService.WebApi.Controllers
{
    public class ReportInfo
    {

        public ReportInfo()
            {
            CaseQualitativeData = new CaseQualitativeData();
            }
        public string Template { get; set; }
        public CaseQualitativeData CaseQualitativeData { get; set; }
    }

    public class QuantiativeReportInfo
    {

        public QuantiativeReportInfo()
        {
            CaseQuantitativeData = new CaseQuantitativeData();
        }
        public string Template { get; set; }
        public CaseQuantitativeData CaseQuantitativeData { get; set; }
    }
}
