using System;
using System.Linq;
using Newtonsoft.Json;
using domain_info.Models;

namespace domain_info.Services {
    public class ReverseIpServiceParser : IServiceParser {
        public object ParseDomainInfo(DomainInfo domainInfo) {
            ReverseIP geo = JsonConvert.DeserializeObject<ReverseIP>(domainInfo.ServiceResult);

            SimplifiedReverseIP srip = new SimplifiedReverseIP();
            srip.reverseIpData = geo.result.Select(r 
                => new ReverseIpData() {
                    DomainName = r.name,
                    FirstSeen = new DateTime(r.first_seen)
                }).ToArray();
            return srip;
        }
    }
}
