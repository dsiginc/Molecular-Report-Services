using Molecular.DataAccess.AccessionService.Objects;
using Molecular.DataAccess.ReportsService;
using Molecular.DataAccess.ToxicologyAccessionService;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using Telerik.Reporting.XmlSerialization;
using Excel = Microsoft.Office.Interop.Excel;


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
        public async Task<string> CreateLabOrderRequisitionReport(LabOrderReport dataSource, string templateName)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + templateName + ".trdx";

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
        public async Task<string> CreateAntiBodyTestReport(LabOrderReport dataSource, string templateName)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + templateName + ".trdx";

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
            int seriesCount = dataSource.PreviousHistoryChartData.Select(x => x.Name).Distinct().Count();
            int xAxisDataCount = dataSource.PreviousHistoryChartData.Select(x => x.DateCollected).Distinct().Count();
            //dataSource.ChartData = await this.GenerateChartImageFromXlsxFile("", "", dataSource.PreviousHistoryExcelChartData, seriesCount, xAxisDataCount);
            Console.Write(dataSource.ToString());
            Console.WriteLine(templateName);
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
        public async Task<string> CreateQCClinicalDataReport(ReportQCClinicalData dataSource, string templateName)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + templateName + ".trdx";

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
        public async Task<string> CreateQcDataReport(QCDataReport dataSource, string templateName)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + templateName + ".trdx";

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
        public async Task<string> CreateFaxCoverSheet(FaxReportQueue dataSource, string templateName= "FaxCoverSheet")
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + templateName + ".trdx";

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

        public async Task<string> CreateShippingContainerReport(ShippingContainerDataObject dataSource, string templateName)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + templateName + ".trdx";

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
        public async Task<string> CreateToxLabOrderRequisitionReport(ToxLabOrderReportData dataSource, string templateName= "ToxLabOrderRequisitionReport.trdx")
        {
            
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\"+templateName;

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
        public async Task<string> CreateMillenniumHealthReport(MillenniumHealthCaseReportData dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\"+ dataSource.TemplateName;

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

        public async Task<string> CreatInvoiceReport(InvoiceReportData dataSource)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\InvoiceTemplate.trdx";

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
        public async Task<string> CreateChemicalTestReportReport(ChemicalTestReportData dataSource, string templateName)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\"+ templateName;

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

        //public async Task<string> GetAccessToken()
        //{
        //    UserPasswordCredential creds = new UserPasswordCredential("Vanaja.b@dsiginc.com", "Welcome@123");
        //    AuthenticationResult authenticationResult = null;
        //    var authenticationContext = new AuthenticationContext("https://login.windows.net/common/oauth2/token/");

        //    authenticationResult = await authenticationContext.AcquireTokenAsync("https://analysis.windows.net/powerbi/api", "c565eea1-4938-468e-8d5f-35b74ac5e8e5", creds);// new ClientCredential(Secrets.ClientID,Secrets.ClientSecret));
        //    return authenticationResult.AccessToken.ToString();

        //}

        public async Task<string> CreatePGXCaseReport(PGXCaseReportData dataSource)
        {

            string filePath = System.Configuration.ConfigurationManager.AppSettings["ReportTemplateLocation"].ToString() + "\\" + dataSource.TemplateName;

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

        public async Task<byte[]> GenerateChartImageFromXlsxFile<TListEntity>(string excelChartTemplateName, string outPutFolder, IEnumerable<TListEntity> inputItems, int seriesCount, int xAxisDataCount)
        {
            if (inputItems != null && inputItems.Count() > 0)
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;

                outPutFolder = System.Configuration.ConfigurationManager.AppSettings["ChartOutputFolder"].ToString();//"C:\\ReportsGenerated\\Chart\\OutPuts";
                excelChartTemplateName = System.Configuration.ConfigurationManager.AppSettings["ChartTemplate"].ToString();//"C:\\ReportsGenerated\\Chart\\InPuts\\FinalTemplate_Test_good_series_xaxis_1.xlsx"; //
                Console.WriteLine(excelChartTemplateName);
                Console.WriteLine(outPutFolder);

                object misValue = System.Reflection.Missing.Value;
                xlApp = new Excel.Application();
                //xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkBook = xlApp.Workbooks.Open(excelChartTemplateName);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                try
                {
                    string[] properties = new string[] { "Name", "ValuePrev1", "ValuePrev2", "ValuePrev3", "ValuePrev4", "ValuePrev5", "ValuePrev6" };

                    List<TListEntity> items = new List<TListEntity>();
                    foreach (var item in inputItems)
                    {
                        items.Add(item);
                    }
                    Excel.Range chartRangeXaxis;
                    Excel.Range chartRange;
                    var rangeToValue = "";
                    var xAxisRangeToValue = "";
                    int i = 0;
                    var h = 0;
                    int[] alphabetNumArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

                    int i_clear = 0;
                    var h_clear = 0;
                    //clearing existing values
                    for (; i_clear < 4; i_clear++)//rows clearing
                    {
                        for (; h_clear < 4; h_clear++)//columns clearing
                        {
                            xlWorkSheet.Cells[(i_clear + 1), alphabetNumArray[h_clear]] = "";
                        }
                    }

                    for (i = 0; i < items.Count(); i++)
                    {
                        for (h = 0; h < xAxisDataCount + 1; h++)
                        {
                            string propertyName = properties[h];
                            var property = items[i].GetType().GetProperty(propertyName);
                            if (property != null)
                            {
                                var value = property.GetValue(items[i], null);
                                if (value != null)//required to check, for not allowing empty values
                                {
                                    xlWorkSheet.Cells[(i + 1), alphabetNumArray[h]] = value;
                                    //xlWorkSheet.Cells["A2"] = value;//this type was not works on microsoft.office.interop.excel
                                    //xlWorkSheet.Cells[1,2] = value;//this is correct one

                                }
                                //else
                                //    xlWorkSheet.Cells[(i + 1), alphabetNumArray[h]] = "";
                            }
                        }
                    }
                    string[] alphabetArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                    rangeToValue = alphabetArray[xAxisDataCount] + i;
                    xAxisRangeToValue = alphabetArray[xAxisDataCount] + 1;


                    Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                    //Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);//for new one
                    Excel.ChartObject chartObject = (Excel.ChartObject)xlCharts.Item(1);
                    Excel.Chart chart = chartObject.Chart;

                    chartRangeXaxis = xlWorkSheet.get_Range("B1", xAxisRangeToValue);
                    chartRange = xlWorkSheet.get_Range("A2", rangeToValue);
                    //chartPage.SetSourceData(chartRangeXaxis, Excel.XlRowCol.xlRows);
                    chart.SetSourceData(chartRange, Excel.XlRowCol.xlRows);//sucess
                                                                               //chartPage.ChartType = Excel.XlChartType.xlLineMarkers;//if creating new chart uncomment this one

                    Excel.Axis xAxis = (Excel.Axis)chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);

                    xAxis.HasTitle = false;
                    //xAxis.AxisTitle.Caption = "Time";
                    xAxis.CategoryNames = (Excel.Range)xlWorkSheet.get_Range("B1", xAxisRangeToValue);

                    Excel.Range formatRange;
                    formatRange = xlWorkSheet.get_Range("B2", rangeToValue);
                    formatRange.NumberFormat = "#,##0.00";

                    //chartPage.ChartArea.Width = 200;
                    //chartPage.ChartArea.Height = 100;

                    // chartPage.CategoryLabelLevel = Excel.XlCategoryLabelLevel.xlCategoryLabelLevelCustom;
                    //not working properly
                    //Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)chartPage.SeriesCollection();
                    //Excel.Series series = seriesCollection.NewSeries();
                    //series.XValues = chartRangeXaxis;

                    //have to set for data labels number format as 0.00
                    //var series = chartObject.Chart.SeriesCollection() as Excel.SeriesCollection;
                    //foreach (var ser in series)
                    //{
                    //    var DataLabels = ((Excel.Series)ser).DataLabels(1);
                    //    DataLabels.
                    //}

                    var imageFileFullName = outPutFolder + @"\ChartImage_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".png";
                    chart.Export(imageFileFullName, "PNG", false);

                  

                    try
                    {
                        //xlWorkBook.SaveAs(outPutFolder + @"\Excel_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".xlsx", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.SaveAs(outPutFolder + @"\Excel_" + DateTime.Now.ToString("yyyyMMddHHmmss")+DateTime.Now.Millisecond.ToString(), Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);

                        //xlWorkBook.SaveAs(outPutFolder + @"\Excel_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss") + ".xlsx", Excel.XlFileFormat.xlXMLSpreadsheet, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlShared, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        await this.releaseObject(xlWorkSheet);
                        await this.releaseObject(xlWorkBook);
                        await this.releaseObject(xlApp);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error closing Excel object" + ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                    finally
                    {
                        if (xlWorkSheet != null) Marshal.ReleaseComObject(xlWorkSheet);
                        if (xlWorkBook != null) Marshal.ReleaseComObject(xlWorkBook);
                        if (xlApp != null) Marshal.ReleaseComObject(xlApp);
                    }


                    try
                    {
                        Console.WriteLine("Reading image");
                        byte[] byteArray = File.ReadAllBytes(imageFileFullName);

                        Console.WriteLine("Reading image 1");

                        System.IO.DirectoryInfo di = new DirectoryInfo(outPutFolder);
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        return byteArray;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Failed to delete " + ex.Message);
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    await this.releaseObject(xlWorkSheet);
                    await this.releaseObject(xlWorkBook);
                    await this.releaseObject(xlApp);
                }
            }           
            return null;
        }

        private async Task<string> releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                // MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
            return "";
        }
    }
}

