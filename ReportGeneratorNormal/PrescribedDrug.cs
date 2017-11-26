namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class PrescribedDrug
    {
        public string CompoundName { get; set; }
        public string Cutoff { get; set; }
        public string Comments { get; set; }
        public string Concetration { get; set; }

        public string DetectionWindow { get; set; }

        public string Result { get; set; }

        public string Class { get; set; }

        public bool ShowColor { get; set; }

    }
}
