using System;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ToxLabOrderDetail
    {
        public long Id { get; set; }
        public string DateCollected { get; set; }
        public string SpecimenTypeName { get; set; }
        public double? Quantity { get; set; }
        public long? QuantityUnits { get; set; }
    }
}
