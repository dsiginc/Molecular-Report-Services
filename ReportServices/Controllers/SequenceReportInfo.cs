using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportGenerator;

namespace ReportServices.Controllers
{
    public class SequenceReportInfo
    {

        public SequenceReportInfo()
            {
            CaseSequenceData = new CaseSequenceData();
            }
        public string Template { get; set; }
        public CaseSequenceData CaseSequenceData { get; set; }
    }


 
}
