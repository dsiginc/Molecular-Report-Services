

namespace ReportGenerator
{
    public class ExtractionReportInfo
    {

        public ExtractionReportInfo()
        {
            ExtractionData = new ExtractionData();
        }
        public string Template { get; set; }
        public ExtractionData ExtractionData { get; set; }
    }
}
