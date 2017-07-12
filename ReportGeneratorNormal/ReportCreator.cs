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

        public  async Task<string> GenerateReport(string template, CaseQualitativeData dataSource)
        {

            //Reference:http://www.telerik.com/forums/programmatically-use-of-trdp-report
            //sample reports:C:\Program Files (x86)\Telerik\Reporting R1 2017\Report Designer\Examples
           

            string filePath= System.Configuration.ConfigurationManager.AppSettings["ReportTempLocation"].ToString()+"\\"+ Guid.NewGuid().ToString()+"_"+ DateTime.Now.ToString("yyyyMMdd_HH_mm_ss")+".trdx";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            Telerik.Reporting.Report report = null;

            byte[] templateBytes = Convert.FromBase64String(template);
            File.WriteAllBytes(filePath, templateBytes);

            using (XmlReader xmlReader = XmlReader.Create(filePath , settings))
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

            byte[] bytes = result.DocumentBytes;
            string response = Convert.ToBase64String(bytes);
            //var reportLocation = ConfigurationManager.AppSettings["ReportTempLocation"];
            //string reportName = reportLocation + "\\"+  dataSource.CaseInfo.CaseNo + "_" + dataSource.CaseInfo.PatientName.Replace(" ", "") + DateTime.Now.ToString() + ".pdf";
            //using (FileStream fs = new FileStream(reportName, FileMode.Create))
            //{
            //    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            //}

            //Converting it to byte array
           // byte[] bytes = System.IO.File.ReadAllBytes(filePath + ".pdf");


            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return response;
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

            byte[] bytes = result.DocumentBytes;
            string response = Convert.ToBase64String(bytes);

            var reportLocation = ConfigurationManager.AppSettings["ReportTempLocation"];
            string reportName = reportLocation + "//" + dataSource.CaseInfo.CaseNo + "_" + dataSource.PatientInfo.PatientName.Replace(" ", "") + DateTime.Now.ToString("yyyyMMdd") + ".pdf";
            using (FileStream fs = new FileStream(reportName, FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return response;
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

            byte[] bytes = result.DocumentBytes;
            string response = Convert.ToBase64String(bytes);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return response;
        }
        public async Task<string> GenerateRunProtocolsReport(RunProtocolsDataInfo dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + dataSource.Template;
           
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

            var reportLocation = ConfigurationManager.AppSettings["ReportTempLocation"];
            string reportName = reportLocation + "//" + dataSource.RunId + "_RunProtocols" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";
            using (FileStream fs = new FileStream(reportName, FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }

            byte[] bytes = result.DocumentBytes;
            string response = Convert.ToBase64String(bytes);

            return response;
        }
        public async Task<string> CreateWorksheetReport(WorksheetReportInfo dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + dataSource.Template;

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

            var reportLocation = ConfigurationManager.AppSettings["ReportTempLocation"];
            string reportName = reportLocation + "//" + dataSource.RunId + "_RunProtocols" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";
            using (FileStream fs = new FileStream(reportName, FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }

            byte[] bytes = result.DocumentBytes;
            string response = Convert.ToBase64String(bytes);

            return response;
        }
    }
}
