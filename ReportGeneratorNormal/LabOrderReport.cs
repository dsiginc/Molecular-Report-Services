﻿using System.Collections.Generic;

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

        public byte[] PhysicianSignature { get; set; }
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
        public string LabClientNPI { get; set; }
        public string LabClientAddress { get; set; }
        public string IcdCodes { get; set; }
        public string CollectionDate { get; set; }
        public string CollectionTime { get; set; }
        public string Etiology { get; set; }
        public string AnatomicAllocation { get; set; }
        public string Orientation { get; set; }
        public string CurrentDate { get; set; }
        public string ProviderName { get; set; }
        public string AuthorizedUserName { get; set; }
        public byte[] AuthorizedUserSignature { get; set; }

        public List<string> TestCodes { get; set; }
        public List<TestCodes> TestCodes_Left { get; set; }
        public List<TestCodes> TestCodes_Right { get; set; }
        public List<string> OrderReasons { get; set; }
        public string OrderOtherReason { get; set; }
        public string OrderDate { get; set; }
        public string LabClientAccountId { get; set; }
        public List<InsuranceDetail> InsuranceDetails { get; set; }
        public string BillingTypeName { get; set; }
        public byte[] LabLogo { get; set; }
        public string LabAddress { get; set; }
        public string LabCLIA { get; set; }
        public string LabDirector { get; set; }

        public string InsuranceCompanyName { get; set; }
        public string InsuranceGroupNumber { get; set; }
        public string InsuranceGroupName { get; set; }
        public string NameOfInsured { get; set; }
        public string InsuredDOB { get; set; }

        public string TemplateName { get; set; }
        public string RelationToPatient { get; set; }
        public string InsuranceId { get; set; }
        public string ValidityOfPolicy { get; set; }
        public string PolicyId { get; set; }

        public string ResultVerifiedBy { get; set; }
        public string AntiBodyTestResult { get; set; }
        public string DateReviewed { get; set; }
        public string ResultComments { get; set; }
        public string OrderNotes { get; set; }
        public string EMRReference { get; set; }
    }
    public class TestCodes
    {
        public string TestCode { get; set; }
    }
}
