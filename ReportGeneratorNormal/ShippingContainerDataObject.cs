using System;
using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ShippingContainerDataObject
    {
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public string ShippingLabel { get; set; }
        public long NoOfSpecimens { get; set; }
        public string LabClientName { get; set; }
        public string LocationName { get; set; }
        public string DateCreated { get; set; }
        public string BarCode { get; set; }
        public List<SpecimensShippingObj> BarCodesOfSpecimens { get; set; }
        public List<BasicCustomDDO>[] BarCodesOfSpecimensSplit { get; set; }
    }
    public class SpecimensShippingObj
    {
        public long? OrderId { get; set; }
        public string SpecimenId { get; set; }
    }
}
