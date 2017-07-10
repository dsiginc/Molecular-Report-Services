using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class RunProtocalsData
    {
        public int StepNumber { get; set; }
        public string Description { get; set; }
        public bool UsePlateSetup { get; set; }
        public bool UseWorksheet { get; set; }
        public bool Completed { get; set; }
        public string Notes { get; set; }
    }
}
