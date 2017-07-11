using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class RunProtocolsDataInfo
    {

        public RunProtocolsDataInfo()
        {
            RunProtocols = new List<RunProtocolsDTO>();
        }
        public string Template { get; set; }
        public long RunId { get; set; }
        public string WorklistName { get; set; }
        public List<RunProtocolsDTO> RunProtocols { get; set; }
    }


 
}
