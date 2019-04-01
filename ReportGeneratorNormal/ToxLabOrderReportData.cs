using Molecular.DataAccess.ReportsService;
using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ToxLabOrderReportData
    {
        public long Id { get; set; }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string DateCollected { get; set; }
        public string DateReceived { get; set; }
        public string ClinicalHistory { get; set; }
        public List<ToxLabOrderDetail> LabOrderDetails { get; set; }


        public string Patient { get; set; }

        public string Physician { get; set; }

        public string SecondaryPhysician { get; set; }

        public string Location { get; set; }

        public string IcdCodes { get; set; }

        public string SpecimenSource { get; set; }

        public string QuantityWithUnits { get; set; }
        public string StatusName { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string PrescribedDrugs { get; set; }
        public string LabName { get; set; }
        public string LabAddress { get; set; }
        public string LabCountry { get; set; }
        public string LabState { get; set; }
        public string LabZip { get; set; }
        public string Compounds { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string PhysicianContactNumber { get; set; }
        public string PhysicianFaxNumber { get; set; }
        public string PhysicianAddress { get; set; }
        public string PhysicianCity { get; set; }
        public string PhysicianState { get; set; }
        public string PhysicianZip { get; set; }
        public string SpecimenTypeName { get; set; }

        public string NameOfInsured { get; set; }
        public string RelationToPatient { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string InsuranceId { get; set; }
        public string InsuranceGroupName { get; set; }
        public string InsuranceGroupNumber { get; set; }
        public string ValidityOfPolicy { get; set; }
        public string PolicyId { get; set; }

        public string LabFaxNumber { get; set; }
        public string PatientContactNumber { get; set; }
        public string PatientAddress { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientZip { get; set; }
        public string PatientSSN { get; set; }
        public string ProfileName { get; set; }
        public byte[] LabLogo { get; set; }
        public string MedicalNecessityText { get; set; }
        public byte[] PhysicianSignature { get; set; }
        public byte[] PatientSignature { get; set; }
        public bool ShowMedicalNecessity { get; set; }

        public string SpecimenID { get; set; }
        public string AccessionID { get; set; }
        public string LabDirector { get; set; }
        public string CliaID { get; set; }
        public string CollectionTime { get; set; }
        public string LabClientName { get; set; }
        public string LabClientAddress { get; set; }
        public string LabClientNPI { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleInitial { get; set; }
        public string PatientGender { get; set; }
        public string PatientDateOfBirth { get; set; }
        public string OrderDate { get; set; }
        public string AuthorizedUserName { get; set; }

        public List<string> OrderReasons { get; set; }
        public string OrderOtherReason { get; set; }
        public List<InsuranceDetail> InsuranceDetails { get; set; }
        public List<string> TestCodes { get; set; }
        public List<string> EmrTestCodes { get; set; }
        public string Fastinghours { get; set; }
        public string SpecimenCollecterName { get; set; }
        public List<string> ProfileIds { get; set; }
        public List<BasicCustomDDO> MiscTests { get; set; }
        public string LabAbbreviation { get; set; }
        //Access
        public List<BasicCustomDDO>[] PrescribedDrugsList { get; set; }
        public List<BasicCustomDDO>[] ProfileNameForAccess { get; set; }
        public List<BasicCustomDDO>[] CompoundsList { get; set; }
    }
    public class BasicCustomDDO
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
