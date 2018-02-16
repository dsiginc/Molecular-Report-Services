using System.Collections.Generic;

namespace Molecular.DataAccess.ReportsService
{
    public class LabOrderReport
    {
        public long Id { get; set; }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string ClinicalIcdCodes { get; set; }
        public string ClinicalHistory { get; set; }
        public List<LabOrderDetail> LabOrderDetails { get; set; }
        public ReportServicePhysicianInfo ReportPhysicianInfo { get; set; }
        public ReportServicePatient ReportPatient { get; set; }
        public List<ReportSpecimenPanel> ReportSpecimenPanels { get; set; }


        public string Patient { get; set; }

        public string Physician { get; set; }

        public string SecondaryPhysician { get; set; }

        public string Location { get; set; }

        public string SpecimenType { get; set; }

        public string SpecimenSource { get; set; }

        public string QuantityWithUnits { get; set; }
        public string StatusName { get; set; }
        public string MedicalRecordNumber { get; set; }

        public string SpecimenID { get; set; }
        public string AccessionID { get; set; }//caseNo
        public string LabClientName { get; set; }
        public string LabClientAddress { get; set; }
        public string IcdCodes { get; set; }
        public string CollectionDate { get; set; }
        public string CollectionTime { get; set; }
        public string Etiology { get; set; }
        public string AnatomicAllocation { get; set; }
        public string Orientation { get; set; }
    }
}
