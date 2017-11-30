using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ToxLabOrderReportData
    {
        public long Id { get; set; }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string DateCollected { get; set; }
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
    }
}
