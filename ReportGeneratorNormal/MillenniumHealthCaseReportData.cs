using System.Collections.Generic;

namespace Molecular.DataAccess.AccessionService.Objects
{

    public class MillenniumHealthCaseReportData
    {
        public string TemplateName { get; set; }
        public string PatientName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string MRN { get; set; }
        public string SSN { get; set; }
        /*----CaseInfo---start--*/
        public string SpecimenID { get; set; }
        public string AccessionID { get; set; }//caseNo
        public string OrderingPhysician { get; set; }
        public string SpecimenType { get; set; }
        public string LabClientName { get; set; }
        public string LabClientAddress { get; set; }
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
        public List<ResultSummery> ResistanceGeneResultSummery { get; set; }
        public List<ResultSummery> ResistanceGeneSummary { get; set; }
        public List<ResultSummery> OrganismsResultSummery { get; set; }
        public List<ResultSummery> VirulenceGeneResultSummery { get; set; }
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
        public byte[] LabLogo { get; set; }
        public string LabCLIA { get; set; }
        public string LabDirector { get; set; }
        public List<Resistance> Resistances { get; set; }
        public List<LucidResults> LucidResults_Left { get; set; }
        public List<LucidResults> LucidResults_Right { get; set; }
        public bool ResistanceSummeryExist { get; set; }
        public string ProfilesOrdered { get; set; }
        //Test Results - Will hard the tables on the report with the test names but need to find a way to set on the report.

        public bool ShowResistanceGenes { get; set; }
        public bool ShowComments { get; set; }
        public string Phone { get; set; }
        public bool OrganismsDetected { get; set; }
        public bool ResistanceDetected { get; set; }
        public List<UTIResultsSet> Results { get; set; }
        public List<UTIResultsSet> ResistanceResults { get; set; }
        public string CaseStatus { get; set; }
        public List<LucidResults> LucidResultsWithQcControl { get; set; }
        public string FinalInterPretation { get; set; }
        public string PatientContactNumber { get; set; }
        public string PathologistName { get; set; }
        public string LabAddress { get; set; }
        public string LabPhone { get; set; }
        public string LabFax { get; set; }
        public string ProviderNPI { get; set; }
        public string LabClientPhone { get; set; }
        public string LabClientFax { get; set; }
        public long PatientId { get; set; }
        public string PatientRace { get; set; }
        public string PatientAddress { get; set; }
        public string Tests { get; set; }
    }
    public class UTIResultsSet
    {
        public string TestCategory { get; set; }
        public string TestName { get; set; }
        public string Result { get; set; }
        public double Concentration { get; set; }
        public string ClinicalInterpretation { get; set; }
        public string ResistanceSpectrum { get; set; }
        public string Notes { get; set; }
    }
    public class ResultSummery
    {
        public string GeneName { get; set; }
        public string Category { get; set; }
        public string Spectrum { get; set; }
        public string Notes { get; set; }
        public string Summary { get; set; }
        public string NotesSuperscript { get; set; }
        public string SummarySuperscript { get; set; }
        public string SpectrumSuperscript { get; set; }
        public string GeneSuperscript { get; set; }
        public string CategorySuperscript { get; set; }
        public double Concentration { get; set; }
        public string TestCode { get; set; }
        public long TestResultId { get; set; }
    }
    public class Resistance
    {
        public string TestName { get; set; }
        public string Summary { get; set; }
    }
    public class LucidResults
    {
        public string TestName { get; set; }
        public string Result { get; set; }
    }
}
