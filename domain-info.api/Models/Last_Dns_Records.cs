using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class Last_Dns_Records {
        public string rname { get; set; }
        public int retry { get; set; }
        public int refresh { get; set; }
        public int minimum { get; set; }
        public string value { get; set; }
        public int expire { get; set; }
        public int ttl { get; set; }
        public int serial { get; set; }
        public string type { get; set; }
        public int priority { get; set; }
    }
}
