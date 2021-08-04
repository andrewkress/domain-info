using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Services {
    public static class ServiceParserFactory {
        public static IServiceParser GetParserForService(String service) {
            if(service.Equals("whois")) {
                return new WhoisServiceParser();
            } else if (service.Equals("geo")) {
                return new GeoServiceParser();
            } else if (service.Equals("reverseip")) {
                return new ReverseIpServiceParser();
            } else if (service.Equals("virustotal")) {
                return new VirusTotalParser();
            }

            throw new Exception("Invalid Service Parser");
        }
    }
}
