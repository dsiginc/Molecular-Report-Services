using System;
using System.Collections.Generic;
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

            using (FileStream fs = new FileStream(@"c:\report\JGD.pdf", FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }

            //Converting it to byte array
           // byte[] bytes = System.IO.File.ReadAllBytes(filePath + ".pdf");


            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return response;
        }
    }
}
