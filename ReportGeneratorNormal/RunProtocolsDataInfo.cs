﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportGenerator;

namespace ReportGenerator
{
    public class RunProtocolsDataInfo
    {

        public RunProtocolsDataInfo()
        {
            RunProtocols = new List<RunProtocolsDTO>();
        }
        public string FolderPath { get; set; }
        public string ServerUrl { get; set; }
        public long RunId { get; set; }
        public string WorklistName { get; set; }
        public List<RunProtocolsDTO> RunProtocols { get; set; }
    }


 
}
