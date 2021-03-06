﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molecular.DataAccess.AccessionService.Objects
{
    public class SpecimenInfoData
    {
    
        public string CollectionLocation { get; set; }

        public string CollectionContact { get; set; }

        public string ReferenceNo { get; set; }

        public int ExtractNumber { get; set; }
       
        public string Notes { get; set; }

       
        public string CollectionTime { get; set; }

     
        public string TransportTime { get; set; }

       
        public string ExtractionDate { get; set; }

    
        public double NAQuality { get; set; }

    
        public string TypeName { get; set; }

        public string SourceName { get; set; }

       
        public string CollectionProviderName { get; set; }

      
        public string CollectionMediaName { get; set; }

     
        public string CollectionContainerName { get; set; }

     
        public string TransportContainerName { get; set; }

      
        public string TransportMediaName { get; set; }

     
        public string QuantityAvailable { get; set; }

        public bool Hemolysis { get; set; }


        public bool Anticoagulant { get; set; }

      
        public bool InappropriateTransportTemperature { get; set; }

     
        public bool SpecimenClotted { get; set; }

     
        public bool SpecimenThawed { get; set; }

   
        public bool SpecimenImproperlyLabeled { get; set; }

       
        public bool AmnioticSpecimenMaternalContamination { get; set; }

       
        public bool Rejected { get; set; }

    
        public string RejectionReason { get; set; }

      
        public string NAType { get; set; }


        public string ReceivedDate { get; set; }

    }
}
