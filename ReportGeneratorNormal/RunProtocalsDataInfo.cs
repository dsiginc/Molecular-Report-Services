using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportGenerator;

namespace ReportGenerator
{
    public class RunProtocalsDataInfo
    {

        public RunProtocalsDataInfo()
        {
            RunProtocals = new List<RunProtocalsDTO>();
        }
        public string Template { get; set; }
        public string RunNumber { get; set; }
        public string WorklistName { get; set; }
        public List<RunProtocalsDTO> RunProtocals { get; set; }
    }


 
}
