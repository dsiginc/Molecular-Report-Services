﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class CaseQualitativeData
    {

        public CaseQualitativeData()
        {
            CaseInfo = new CaseData();
            CaseTestInfo = new CaseTestData();
            PatientInfo = new PatientInfoData();
            SpecimenInfo = new SpecimenInfoData();
        }
        public CaseData CaseInfo { get; set; }

        public CaseTestData CaseTestInfo { get; set; }

        public PatientInfoData PatientInfo { get; set; }

        public SpecimenInfoData SpecimenInfo { get; set; }
    }

 
}
