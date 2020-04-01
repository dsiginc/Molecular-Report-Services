using System;
using System.Collections.Generic;
using System.Text;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportQCClinicalData
    {
        public string Instrument { get; set; }
        public string Month { get; set; }
        public long Year { get; set; }
        public IEnumerable<CompoundsListWithQCClinicalData> CompoundsListWithQCClinicalDataList { get; set; }
        public List<CompoundsListForQCClinicalChartsTables> CompoundsListForQCClinicalChartsTables { get; set; }
    }
    public class CompoundsListWithQCClinicalData
    {
        public string CompoundName { get; set; }
        public IEnumerable<ChemistryQCData> ChemistryQCDataResponseObj { get; set; }
    }
    public class CompoundsListForQCClinicalChartsTables
    {
        public string CompoundName { get; set; }
        public List<ChartTableObjWithQcClinicalControl> ChartTableObjWithQcClinicalControlList { get; set; }
    }
    public class ChartTableObjWithQcClinicalControl
    {
        public string QcControl { get; set; }
        public List<ChartObjQcClinical> ChartObjQcClinicalList { get; set; }
        public List<TableValueDataObjQcClinical> TableValueDataObjQcClinicalList { get; set; }
    }
    public class ChartObjQcClinical
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public string QcControlName { get; set; }
        public string CompoundName { get; set; }
        public long score { get; set; }
        public double Mean { get; set; }
        public double ThreeSD { get; set; }
        public double TwoSD { get; set; }
        public double OneSD { get; set; }
        public double MinusOneSD { get; set; }
        public double MinusTwoSD { get; set; }
        public double MinusThreeSD { get; set; }
        public string Range { get; set; }
        public double CV { get; set; }
        public string Title { get; set; }
    }
    public class TableValueDataObjQcClinical
    {
        public string Date { get; set; }
        public string Value1 { get; set; }
        public bool SkipValue1 { get; set; }
        public string Comment1 { get; set; }
        public string Value2 { get; set; }
        public bool SkipValue2 { get; set; }
        public string Comment2 { get; set; }
        public string Value3 { get; set; }
        public bool SkipValue3 { get; set; }
        public string Comment3 { get; set; }
        public string Average { get; set; }
        public string QcControlName { get; set; }
        public string QCPass { get; set; }
        public long score { get; set; }
    }
    public class ChemistryQCData
    {
        public string ControlName { get; set; }
        public double Mean { get; set; }
        public double SD { get; set; }
        public double ThreeSD { get; set; }
        public double TwoSD { get; set; }
        public double OneSD { get; set; }
        public double MinusOneSD { get; set; }
        public double MinusTwoSD { get; set; }
        public double MinusThreeSD { get; set; }
        public IEnumerable<QCDataList> QCDataList { get; set; }
        public string Range { get; set; }
    }
    public class QCDataList
    {
        public string Date { get; set; }
        public string Concentration { get; set; }
        public string ControlName { get; set; }
        public string QCPass { get; set; }
    }
}
