using System;

namespace Molecular.DataAccess.ReportsService
{
    public class InsuranceDetail
    {
        public string InsuredName { get; set; }
        public string RelationshipToPatient { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string StateName { get; set; }

        public string TypeOfInsurance { get; set; }
        public string EffectiveDate { get; set; }
        public string RelationshipToSubscriber { get; set; }
        public string SubscriberName { get; set; }
        public string Policyid { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string PlanType { get; set; }
        public string InsurancePhone { get; set; }
        public string InsuranceAddress { get; set; }
        public string InsuranceCity { get; set; }
        public string InsuranceZip { get; set; }
        public string InsuranceState { get; set; }

        public string LabClientName { get; set; }
        public string LabClientAccountId { get; set; }
        public string LabClientAddress { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientGender { get; set; }
        public string PatientSSN { get; set; }
        public string PatientDOB { get; set; }
    }
}
