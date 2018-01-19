using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class BillingReportDataObject
    {
        public BillingReportDataObject()
        {

        }
        public BRPatientInfo PatientInfo { get; set; }
        public BRInsuranceCompanyInfo PrimaryInsuranceCompanyInfo { get; set; }
        public BRInsuranceCompanyInfo SecondaryInsuranceCompanyInfo { get; set; }
        public BRPhysicianInfo PhysicianInfo { get; set; }
        public BRInterpretingScientist InterpretingScientist { get; set; }
        public List<BRTestsPerformed> TestsPerformed { get; set; }
        public string IcdCodes { get; set; }
        public string CptCodes { get; set; }
    }
}
