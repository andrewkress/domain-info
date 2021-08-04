using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class SimplifiedVirusTotal {
        public VirusTotalData virusTotalData { get; set; }
    }
    public class VirusTotalData {
        public int Reputation { get; set; }
        public int LastAnalysisHarmless { get; set; }
        public int LastAnalysisMalicious { get; set; }
        public int LastAnalysisSuspicious { get; set; }
        public int LastAnalysisUndetected { get; set; }
        public int LastAnalysisTimeout { get; set; }

    }
}
