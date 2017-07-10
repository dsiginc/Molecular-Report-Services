using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportGenerator;

namespace ReportingService.WebApi.Controllers
{
    public class RunProtocalsDataInfo
    {

        public RunProtocalsDataInfo()
            {
            RunProtocalsData = new List<RunProtocalsData>();
            }
        public string Template { get; set; }
        public List<RunProtocalsData> RunProtocalsData { get; set; }
    }


 
}
