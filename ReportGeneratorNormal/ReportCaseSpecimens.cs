﻿using System;
using System.Collections.Generic;

namespace Molecular.DataAccess.ToxicologyAccessionService
{
    public class ReportCaseSpecimens
    {
        public ReportCaseSpecimens()
        {
            CaseResultList = new List<ReportCaseResultList>();
        }
        public long Id { get; set; }
        public long CaseOrderId { get; set; }
        public long SpecimenTypeId { get; set; }
        public double? Quantity { get; set; }
        public long? QuantityUnits { get; set; }
        public string SpecimenId { get; set; }
        public string SpecimenTypeName { get; set; }
        public bool IsEdited { get; set; }
        public DateTime? DateCollected { get; set; }
        public List<ReportCaseResultList> CaseResultList { get; set; }
    }
    public class ReportCaseResultList
    {
        public ReportCaseResultList()
        {
            CaseResults = new List<ReportCaseResult>();
        }
        public List<ReportCaseResult> CaseResults { get; set; }
    }
}
