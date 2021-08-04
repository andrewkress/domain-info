using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class SimplifiedReverseIP {
        public ReverseIpData[] reverseIpData { get; set; }
    }

    public class ReverseIpData {
        public String DomainName { get; set; }
        public DateTime FirstSeen { get; set; }
}
}
