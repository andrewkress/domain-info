using System;
using Newtonsoft.Json;
using domain_info.Models;

namespace domain_info.Services {
    public class VirusTotalParser : IServiceParser {
        public object ParseDomainInfo(DomainInfo domainInfo) {
            VirusTotal virusTotal = JsonConvert.DeserializeObject<VirusTotal>(domainInfo.ServiceResult);

            SimplifiedVirusTotal vt = new SimplifiedVirusTotal() {
                virusTotalData = new VirusTotalData() {
                    Reputation = virusTotal.data.attributes.reputation,
                    LastAnalysisHarmless = virusTotal.data.attributes.last_analysis_stats.harmless,
                    LastAnalysisMalicious = virusTotal.data.attributes.last_analysis_stats.malicious,
                    LastAnalysisSuspicious = virusTotal.data.attributes.last_analysis_stats.suspicious,
                    LastAnalysisUndetected = virusTotal.data.attributes.last_analysis_stats.undetected,
                    LastAnalysisTimeout = virusTotal.data.attributes.last_analysis_stats.timeout
                }
            };
            return vt;
        }
    }
}
