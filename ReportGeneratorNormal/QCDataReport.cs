using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class QCDataReport
    {
        public string Instrument { get; set; }
        public string Month { get; set; }
        public long Year { get; set; }
        public IEnumerable<CompoundsListWithQCData> CompoundsListWithQCDataList { get; set; }
        public List<CompoundsListForChartsTables> CompoundsListForChartsTables { get; set; }
    }
    public class CompoundsListWithQCData 
    {
        public string CompoundName { get; set; }
        public IEnumerable<RunQCDataResponseObj> RunQCDataResponseObj { get; set; }
    }
    public class CompoundsListForChartsTables
    {
        public string CompoundName { get; set; }
        public List<ChartTableObjWithQcControl> ChartTableObjWithQcControlList { get; set; }
    }
    public class ChartTableObjWithQcControl
    {
        public string QcControl { get; set; }
        public List<ChartObj> ChartObjList { get; set; }
        public List<TableValueDataObj> TableValueDataObjList { get; set; }
    }
    public class ChartObj
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
    public class TableValueDataObj
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
        public List<BasicCustomDDO>[] ToxQCDetailsSplit { get; set; }
    }
    public class RunQCDataResponseObj
    {
        public string Name { get; set; }
        public double Mean { get; set; }
        public double SD { get; set; }
        public double ThreeSD { get; set; }
        public double TwoSD { get; set; }
        public double OneSD { get; set; }
        public double MinusOneSD { get; set; }
        public double MinusTwoSD { get; set; }
        public double MinusThreeSD { get; set; }
        public IEnumerable<RunQCDataResults> RunQCDataResults { get; set; }
        public string TheoreticalMeanv { get; set; }
        public string Range { get; set; }
    }
    public class RunQCDataResults
    {
        public string Date { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Average { get; set; }
        public string RunId { get; set; }
        public string QCPass { get; set; }
        public long score { get; set; }
        public bool SkipValue1 { get; set; }
        public bool SkipValue2 { get; set; }
        public bool SkipValue3 { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public long Id1 { get; set; }
        public long Id2 { get; set; }
        public long Id3 { get; set; }
    }

}
