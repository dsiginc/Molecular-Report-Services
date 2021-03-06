﻿namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class PrescribedDrug
    {
        public string CompoundName { get; set; }
        public string Cutoff { get; set; }
        public string Comments { get; set; }
        public string Concetration { get; set; }
        public string ConcetrationUnits { get; set; }
        public string DetectionWindow { get; set; }
        public string CreatinineAdjustment { get; set; }
        public string Result { get; set; }

        public string Class { get; set; }

        public bool ShowColor { get; set; }

        public bool ShowRedColor { get; set; }
        public string RowColor { get; set; }
        public string Prescription { get; set; }
        public string Flag { get; set; }
        public long DisplayOrder { get; set; }
        public bool Expected { get; set; }
        public bool Inconsistent { get; set; }
        public string ConcentrationForCalc { get; set; }
    }
}
