using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReportGenerator;

namespace ReportingService.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
       
        // POST api/values
        [HttpPost("CreateReport")]
        public async Task<string> CreateReport([FromBody]ReportInfo reportInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.GenerateReport(reportInfo.Template, reportInfo.ReportData);

        }

        
    }
}
