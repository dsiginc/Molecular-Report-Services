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
            return await report.GenerateReport(reportInfo.Template, reportInfo.CaseQualitativeData);

        }

        // POST api/values
        [HttpPost("CreateQuantitativeReport")]
        public async Task<string> CreateQuantitativeReport([FromBody]QuantitativeReportInfo reportInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.GenerateQuantiativeReport(reportInfo.Template, reportInfo.CaseQuantitativeData);

        }


        [HttpPost("CreateSequenceReport")]
        public async Task<string> CreateSequenceReport([FromBody]SequenceReportInfo reportInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.GenerateSequenceReport(reportInfo.Template, reportInfo.CaseSequenceData);

        }
        [HttpPost("CreateRunProtocolReport")]
        public async Task<string> CreateRunProtocolReport([FromBody]RunProtocalsDataInfo runProtocalsDataInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.GenerateRunProtocalsReport(runProtocalsDataInfo.Template, runProtocalsDataInfo.RunProtocalsData);

        }
    }
}
