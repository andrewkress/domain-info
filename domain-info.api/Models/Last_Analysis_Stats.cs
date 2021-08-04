using System;

namespace domain_info.Models {
    public class Last_Analysis_Stats {
        public int harmless { get; set; }
        public int malicious { get; set; }
        public int suspicious { get; set; }
        public int undetected { get; set; }
        public int timeout { get; set; }
    }
}
