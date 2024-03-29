﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.PEF.Models.PEF
{
  public   class PEFDhhsAMhTierInfoGrp5xDTO
    {
        // -- Unique key combination   -- start 
        [StringLength(10)]
        public string ProvNPI { get; set; }
        [StringLength(10)]
        public string ProvNCTracksId { get; set; }
        [StringLength(1)]
        public string ProvEnrollmentType { get; set; }
        // Refer: Service Location Code (key)
        [StringLength(3)]
        public string ProvSvcLocCode { get; set; }
        // -- Unique key combination   -- END  

        // Order # - for unique record 
        public Int64? Order { get; set; }

        [StringLength(1)]
        public string DHHSSpAMHTierTypeCode { get; set; }          //Length: 1 
        [StringLength(10)]
        public string DHHSSpAMHTierEffectiveDt { get; set; }      //Length: 10
        [StringLength(10)]
        public string DHHSSpAMHTierEndDt { get; set; }           //Length: 10 
    }

    // for single item-level parsing
  public class DhhsSpAmhTierInfo
    {
        public string DHHSSpAMHTierTypeCode { get; set; }          //Length: 1 
        public string DHHSSpAMHTierEffectiveDt { get; set; }      //Length: 10
        public string DHHSSpAMHTierEndDt { get; set; }           //Length: 10 
    }


}
