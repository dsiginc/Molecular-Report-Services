namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportPhysicianInfo
    {
        public ReportPhysicianInfo()
        {
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string BusinessName { get; set; }
        public string City { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public long LabId { get; set; }
        public string Notes { get; set; }
        public long? State { get; set; }        
        public string Zip { get; set; }
        public string FaxNumber { get; set; }
        public bool? Enabled { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string Title { get; set; }
        public string Npi { get; set; }
        public string StateName { get; set; }
        public string UserName { get; set; }
    }
}
