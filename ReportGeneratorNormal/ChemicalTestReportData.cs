using System.Collections.Generic;

namespace ReportGenerator
{
    public class ChemicalTestReportData
    {
        public ChemicalTestReportData()
        {
            PatientInfo = new CTR_Patient();
            LabInfo = new CTR_Lab();
            SpecimenInfo = new CTR_Specimen();
            PhysicianInfo = new CTR_Physician();
            ClinicalTestResults = new List<CTR_ClinicalTestResult>();
        }
        public bool IsCorrected { get; set; }
        public bool IsAmended { get; set; }
        public string CaseComments { get; set; }
        public string DateSigned { get; set; }
        public CTR_Patient PatientInfo { get; set; }
        public CTR_Lab LabInfo { get; set; }
        public CTR_Specimen SpecimenInfo { get; set; }
        public CTR_Physician PhysicianInfo { get; set; }
        public List<CTR_ClinicalTestResult> ClinicalTestResults { get; set; }
    }
    public class CTR_Patient
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string MRN { get; set; }
        public string PatientId { get; set; }
        public string AccessionId { get; set; }
        public string SSN { get; set; }
    }
    public class CTR_Lab
    {
        public byte[] Logo { get; set; }
        public string Address { get; set; }
        public string CLIA { get; set; }
        public string LabDirector { get; set; }
    }
    public class CTR_Specimen
    {
        public string SpecimenType { get; set; }
        public string SpecimenId { get; set; }
        public string CollectionDate { get; set; }
        public string ReceivedDate { get; set; }
        public string ReportDate { get; set; }
    }
    public class CTR_Physician
    {
        public string Name { get; set; }
        public string OfficeOrHospital { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
    public class CTR_ClinicalTestResult
    {
        public string PanelName { get; set; }
        public string CompoundName { get; set; }
        public string Flags { get; set; }
        public string Results { get; set; }
        public string Remarks { get; set; }
        public string Range { get; set; }
        public string PreviousFlag { get; set; }
        public string PreviousResult { get; set; }
        public string PreviousResultDate { get; set; }
        public string ResultDate { get; set; }
        public byte[] Logo { get; set; }
    }
}
