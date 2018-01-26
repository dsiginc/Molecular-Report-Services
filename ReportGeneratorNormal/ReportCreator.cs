using Molecular.DataAccess.ReportsService;
using Molecular.DataAccess.ToxicologyAccessionService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using Telerik.Reporting.XmlSerialization;

namespace ReportGenerator
{
    public class ReportCreator
    {

        public async Task<string> GenerateReport(string template, CaseQualitativeData dataSource)
        {

            //Reference:http://www.telerik.com/forums/programmatically-use-of-trdp-report
            //sample reports:C:\Program Files (x86)\Telerik\Reporting R1 2017\Report Designer\Examples


            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTempLocation"].ToString() + "\\" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            byte[] templateBytes = Convert.FromBase64String(template);
            File.WriteAllBytes(filePath, templateBytes);

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;

            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }

        public async Task<string> GenerateQuantiativeReport(string template, CaseQuantitativeData dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTempLocation"].ToString() + "\\" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            byte[] templateBytes = Convert.FromBase64String(template);
            File.WriteAllBytes(filePath, templateBytes);

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }
          
            report.DataSource = dataSource;

            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }

        public async Task<string> GenerateSequenceReport(string template, CaseSequenceData dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTempLocation"].ToString() + "\\" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            byte[] templateBytes = Convert.FromBase64String(template);
            File.WriteAllBytes(filePath, templateBytes);

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;

            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> GenerateRunProtocolsReport(RunProtocolsDataInfo dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\RunProtocol.trdx";
           
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> CreateWorksheetReport(WorksheetReportInfo dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\WorksheetReport.trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> CreateLabOrderRequisitionReport(LabOrderReport dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\LabOrderRequisitionReport.trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> CreateLabOrdersReport(LabOrdersReport dataSource)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\LabOrdersReport.trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource.LabOrders;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> CreateToxicologyAccessionReport(ReportCaseData dataSource, string templateName)
        {
            Console.Write(dataSource.ToString());
            //string templateName = "ToxicologyAccessionCaseReport";
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\"+ templateName + ".trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            //var reportLocation = ConfigurationManager.AppSettings["ReportTempLocation"];
            //string reportName = templateName+"_" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".pdf";
            //string reportDestination = Path.Combine(reportLocation, reportName);

            //using (FileStream fs = new FileStream(reportDestination, FileMode.Create))
            //{
            //    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            //}
            //string reportUrl = dataSource.ServerUrl + "/" + reportName;
            ////byte[] bytes = result.DocumentBytes;
            //string response = Convert.ToBase64String(bytes);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> CreateToxLabOrderRequisitionReport(ToxLabOrderReportData dataSource)
        {
            
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\ToxLabOrderRequisitionReport.trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            //var reportLocation = ConfigurationManager.AppSettings["ReportTempLocation"];
            //string reportName = dataSource.Id + "_ToxLabOrderRequisition_" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".pdf";
            //string reportDestination = Path.Combine(dataSource.FolderPath, reportName);

            //using (FileStream fs = new FileStream(reportDestination, FileMode.Create))
            //{
            //    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            //}
            //string reportUrl = dataSource.ServerUrl + "/" + reportName;
            //byte[] bytes = result.DocumentBytes;
            //string response = Convert.ToBase64String(bytes);

            return Convert.ToBase64String(result.DocumentBytes);
        }
        public async Task<string> GenerateExtractionReport(string template, ExtractionData dataSource)
        {

            //Reference:http://www.telerik.com/forums/programmatically-use-of-trdp-report
            //sample reports:C:\Program Files (x86)\Telerik\Reporting R1 2017\Report Designer\Examples


            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTempLocation"].ToString() + "\\" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            byte[] templateBytes = Convert.FromBase64String(template);
            File.WriteAllBytes(filePath, templateBytes);

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }
            //ReportPackager reportPackager = new ReportPackager();
            //using (var sourceStream = System.IO.File.OpenRead(@"C:\Users\Razz\Documents\Visual Studio 2015\Projects\SampleReports\src\SampleReports\Templates\Report1.trdp"))
            //{
            //    report = (Telerik.Reporting.Report)reportPackager.UnpackageDocument(sourceStream);
            //}

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }

        public async Task<string> CreateToxBillingReport(BillingReportDataObject dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\ToxBillingReport.trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            using (XmlReader xmlReader = XmlReader.Create(filePath, settings))
            {
                ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();
                report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
            }

            report.DataSource = dataSource;


            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource instanceReportSource = new InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            return Convert.ToBase64String(result.DocumentBytes);
        }

    }
}
