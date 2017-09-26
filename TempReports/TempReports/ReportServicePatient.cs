namespace Molecular.DataAccess.ReportsService
{
    public class ReportServicePatient
    {
        public ReportServicePatient()
        {
        }
        public long Id { get; set; }
        public long Version { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public long LabId { get; set; }
        public long? LabclientId { get; set; }
        public string MedRecNo { get; set; }
        public string Notes { get; set; }
        public string OtherPhone { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientAddress2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientMiddleInitial { get; set; }
        public string PatientState { get; set; }
        public string PatientZip { get; set; }
        public string PatientsAlternativeId2 { get; set; }
        public string PatientsEmail { get; set; }
        public string PatientsEmergencyContactName { get; set; }
        public string PatientsEmergencyContactNumber { get; set; }
        public string PatientsEmergencyContactRelation { get; set; }
        public string PatientsEmploymentStatus { get; set; }
        public string PatientsStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public bool Enabled { get; set; }
        public string AccountNumber { get; set; }
        public string PrimaryCarePhysicianName { get; set; }
        public string PrimaryCarePhysicianAddress1 { get; set; }
        public string PrimaryCarePhysicianAddress2 { get; set; }
        public string PrimaryCarePhysicianCity { get; set; }
        public string PrimaryCarePhysicianState { get; set; }
        public string PrimaryCarePhysicianPhoneNumber { get; set; }
        public string PrimaryCarePhysicianEmail { get; set; }
        public string PrimaryCarePhysicianFax { get; set; }
        public string PrimaryCarePhysicianLocation { get; set; }
        public string PrimaryCarePhysicianZip { get; set; }
    }
}
