using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReportGenerator;
using Molecular.DataAccess.ReportsService;
using Molecular.DataAccess.ToxicologyAccessionService;
using Molecular.DataAccess.AccessionService.Objects;
using System.ComponentModel;
using TokenGenerator;


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
        public async Task<string> CreateRunProtocolReport([FromBody]RunProtocolsDataInfo runProtocolsDataInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.GenerateRunProtocolsReport(runProtocolsDataInfo);

        }
        [HttpPost("CreateWorksheetReport")]
        public async Task<string> CreateWorksheetReport([FromBody]WorksheetReportInfo dataSource)
        {
            ReportCreator report = new ReportCreator();
            return await report.CreateWorksheetReport(dataSource);

        }
        [HttpPost("CreateLabOrderRequisitionReport")]
        public async Task<string> CreateLabOrderRequisitionReport([FromBody]LabOrderReport reportInfo)
        {
            string templateName = "ToxicologyAccessionCaseReport";
            if (reportInfo != null && !string.IsNullOrEmpty(reportInfo.TemplateName))
                templateName = "MolecularRequisitionReport" + reportInfo.TemplateName;

            ReportCreator report = new ReportCreator();
            return await report.CreateLabOrderRequisitionReport(reportInfo, templateName);

        }
        [HttpPost("CreateLabOrdersReport")]
        public async Task<string> CreateLabOrdersReport([FromBody]LabOrdersReport reportInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.CreateLabOrdersReport(reportInfo);

        }
        [HttpPost("CreateCaseReport")]
        public async Task<string> CreateToxicologyAccessionReport([FromBody]ReportCaseData reportInfo)
        {
            string templateName = "ToxicologyAccessionCaseReport";
            if (reportInfo != null && !string.IsNullOrEmpty(reportInfo.TemplateName))
                templateName = templateName + "_" + reportInfo.TemplateName;

            ReportCreator report = new ReportCreator();
            return await report.CreateToxicologyAccessionReport(reportInfo, templateName);

        }
        [HttpPost("CreateToxLabOrderRequisitionReport")]
        public async Task<string> CreateToxLabOrderRequisitionReport([FromBody]ToxLabOrderReportData reportInfo)
        {
            string templateName = "ToxLabOrderRequisitionReport.trdx";
            if (reportInfo != null && !string.IsNullOrEmpty(reportInfo.LabAbbreviation))
                templateName = "ToxRequisitionReport" + reportInfo.LabAbbreviation + ".trdx";
            ReportCreator report = new ReportCreator();
            return await report.CreateToxLabOrderRequisitionReport(reportInfo, templateName);

        }
        [HttpPost("CreateBloodChemistryRequisitionReport")]
        public async Task<string> CreateBloodChemistryRequisitionReport([FromBody]ToxLabOrderReportData reportInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.CreateToxLabOrderRequisitionReport(reportInfo, "BloodChemistryRequisitionReport.trdx");

        }
        // POST api/values
        [HttpPost("CreateExtractionReport")]
        public async Task<string> CreateExtractionReport([FromBody]ExtractionReportInfo reportInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.GenerateExtractionReport(reportInfo.Template, reportInfo.ExtractionData);

        }

        [HttpPost("CreateToxBillingReport")]
        public async Task<string> CreateToxBillingReport([FromBody]BillingReportDataObject billingInfo)
        {
            ReportCreator report = new ReportCreator();
            return await report.CreateToxBillingReport(billingInfo);

        }// POS
        [HttpPost("CreateMillenniumHealthReport")]
        public async Task<string> CreateMillenniumHealthReport([FromBody]string json)
        {
            try
            {
                MillenniumHealthCaseReportData obj = Newtonsoft.Json.JsonConvert.DeserializeObject<MillenniumHealthCaseReportData>(json);
                ReportCreator report = new ReportCreator();
                return await report.CreateMillenniumHealthReport(obj);
            }catch(Exception ex)
            {
                throw ex;
            }

        }
        [HttpPost("CreateInvoiceReport")]
        public async Task<string> CreateInvoiceReport([FromBody]InvoiceReportData data)
        {
            ReportCreator report = new ReportCreator();
            return await report.CreatInvoiceReport(data);

        }
        [HttpPost("CreateChemicalTestReport")]
        public async Task<string> CreateChemicalTestReport([FromBody]ChemicalTestReportData reportInfo)
        {
            string templateName = "ChemicalTestReport.trdx";
            if (reportInfo != null && reportInfo.LabInfo!=null && !string.IsNullOrEmpty(reportInfo.LabInfo.Abbreviation))
                templateName = "BloodChemistryReport"+ reportInfo.LabInfo.Abbreviation + ".trdx";
            ReportCreator report = new ReportCreator();
            return await report.CreateChemicalTestReportReport(reportInfo, templateName);
        }

        [HttpPost("GetAccessToken")]
        public async Task<string> GetAccessToken()
        {
            TokenCreator accessToken = new TokenCreator();
            //ReportCreator report = new ReportCreator();
            return await accessToken.GetAccessToken();
        }
    }
}
