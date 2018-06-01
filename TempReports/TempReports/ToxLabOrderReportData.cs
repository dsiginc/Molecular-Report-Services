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

        public bool ShowMedicalNecessity { get; set; }
    }
}

