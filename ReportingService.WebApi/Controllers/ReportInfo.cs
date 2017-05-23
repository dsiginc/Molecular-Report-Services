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
            ReportData = new CaseQualitativeData();
            }
        public string Template { get; set; }
        public CaseQualitativeData ReportData { get; set; }
    }
}
