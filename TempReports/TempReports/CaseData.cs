using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class CaseData
    {

        public string CaseNo { get; set; }

        public string OrderNo { get; set; }

        public string CaseComments { get; set; }


        public string OrderDate { get; set; }

        public string ClinicalHistory { get; set; }

        public string IcdCodes { get; set; }

          public string StatusName { get; set; }

        public string PhysicianName { get; set; }


        public string SecondaryPhysicianname { get; set; }

        public string PathologistName { get; set; }


        public string PhysicianAddress { get; set; }
    }
}
