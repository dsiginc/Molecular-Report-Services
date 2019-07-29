using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class PGXCaseReportData
    {
        public string TemplateName { get; set; }
        public string PatientName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string MRN { get; set; }
        public string SSN { get; set; }
        public int Age { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientZip { get; set; }
        /*----CaseInfo---start--*/
        public string SpecimenID { get; set; }
        public string AccessionID { get; set; }//caseNo
        public string OrderingPhysician { get; set; }
        public string SpecimenType { get; set; }
        public string LabClientName { get; set; }
        public string LabClientAddress { get; set; }
        public string LabClientCityStateZip { get; set; }
        public string AnatomicLocation { get; set; }//Specimen source
        public string DateReceived { get; set; }
        public string DateCollected { get; set; }
        public string DateSigned { get; set; }//Report Date
        public string OtherComments { get; set; }
        public bool ShowResults { get; set; }
        public string EtiologyName { get; set; }
        public string SpecimenLocationName { get; set; }
        /*----CaseInfo---end--*/
        public Dictionary<string, byte[]> ResultList { get; set; }
        public List<string> PositiveResults { get; set; }
        //public List<ResultSummery> ResistanceGeneResultSummery { get; set; }
        //public List<ResultSummery> OrganismsResultSummery { get; set; }
        //public List<ResultSummery> VirulenceGeneResultSummery { get; set; }
        public string ResistanceGeneNote { get; set; }
        public string OrganismsNote { get; set; }
        public string VirulenceGeneNote { get; set; }

        public string OrganismsUTDText { get; set; }
        public string OrganismsSuperscript { get; set; }
        public string ResistanceGeneUTDTest { get; set; }
        public string ResistanceGeneSuperscript { get; set; }
        public string virulenceGeneUTDTest { get; set; }
        public string VirulenceGeneSuperscript { get; set; }

        public bool LegendNotDetected { get; set; }
        public bool LegendDetected { get; set; }
        public bool LegendNotOrdered { get; set; }
        public bool LegendUTD { get; set; }

        public string CaseComments { get; set; }

        public string DateAmended { get; set; }
        public bool IsAmended { get; set; }
        public bool IsCorrected { get; set; }
        public string AmendedReason { get; set; }
        public string WoundOrientation { get; set; }

        public string DetailedTestResultSuperscript { get; set; }
        //public List<Resistance> Resistances { get; set; }
        //public List<LucidResults> LucidResults_Left { get; set; }
        //public List<LucidResults> LucidResults_Right { get; set; }
        public bool ResistanceSummeryExist { get; set; }

        public byte[] LabLogo { get; set; }
        public string LabCLIA { get; set; }
        public string LabDirector { get; set; }
        public string ProfilesOrdered { get; set; }
        public string LabPhone { get; set; }
        public string LabFax { get; set; }
        public string LabEmail { get; set; }
        public string PrescribedMedications { get; set; }

        //Test Results - Will hard the tables on the report with the test names but need to find a way to set on the report.
        public List<TestDetails> TestDetails { get; set; }

        public List<DrugInterpretations> DrugInterpretations { get; set; }
        public List<DrugInterpretations> PrescribedDrugInterpretations { get; set; }
        public List<DrugsUsage> DrugsUsage { get; set; }
        public List<byte[]> FlagIcons;
    }
    public class TestDetails
    {
        public string Gene { get; set; }
        public string GenoType { get; set; }
        public string PhenoType { get; set; }
        public string AllelesTested { get; set; }
    }

    public class DrugInterpretations
    {
        public string DrugName { get; set; }
        public string MetabolizerType { get; set; }
        public string DrugImpactInterpretation { get; set; }
        public string Evidence { get; set; }
        public string Flag { get; set; }
        public string GeneName { get; set; }
        public string Implication { get; set; }
        public string TherapeuticArea { get; set; }
        public string DrugClass { get; set; }
        public string PhenoTypeDescription { get; set; }
        public string FDALabelSection { get; set; }
    }
    public class DrugsUsage
    {
        public string DrugClass { get; set; }
        public string DrugName { get; set; }
        public string GeneName { get; set; }
        public bool Typical { get; set; }
        public bool DoseAdjustment { get; set; }
        public bool DoseAdjustmentorAlternative { get; set; }
        public bool AlternateDrug { get; set; }
        public bool UncertainorQuestion { get; set; }
        public int ImageIndex { get; set; }
        public string TherapeuticArea { get; set; }
    }
    //public class ResultSummery
    //{
    //    public string GeneName { get; set; }
    //    public string Category { get; set; }
    //    public string Spectrum { get; set; }
    //    public string Notes { get; set; }
    //    public string Summary { get; set; }
    //    public string NotesSuperscript { get; set; }
    //    public string SummarySuperscript { get; set; }
    //    public string SpectrumSuperscript { get; set; }
    //    public string GeneSuperscript { get; set; }
    //    public string CategorySuperscript { get; set; }
    //}
    //public class Resistance
    //{
    //    public string TestName { get; set; }
    //    public string Summary { get; set; }
    //}
    //public class LucidResults
    //{
    //    public string TestName { get; set; }
    //    public string Result { get; set; }
    //}
}
