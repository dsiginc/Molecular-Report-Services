



namespace ReportGenerator
{
   
    public partial class VariantsData
    {
        public VariantsData()
        {

        }
     
       
        public string Interpretation { get; set; }

        public string Comments { get; set; }

        public string VariantId { get; set; }
       
        public string Origin { get; set; }
       
        public string Classification { get; set; }
      
        public bool DnaForwardChange { get; set; }
        public bool DnaReverseChange { get; set; }
       
        public string ZygocityName { get; set; }

        public string Gene { get; set; }
    }
}
