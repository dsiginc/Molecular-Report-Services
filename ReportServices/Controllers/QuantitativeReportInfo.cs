using ReportGenerator;

namespace ReportServices.Controllers
{
    public class QuantitativeReportInfo
    {

        public QuantitativeReportInfo()
            {
            CaseQuantitativeData = new CaseQuantitativeData();
            }
        public string Template { get; set; }
        public CaseQuantitativeData CaseQuantitativeData { get; set; }
    }
}
