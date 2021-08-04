using System;
using Newtonsoft.Json;
using domain_info.Models;


namespace domain_info.Services {
    public class GeoServiceParser : IServiceParser {
        public object ParseDomainInfo(DomainInfo domainInfo) {
            IPStack geo = JsonConvert.DeserializeObject<IPStack>(domainInfo.ServiceResult);

            SimplifiedGeoLookup sgl = new SimplifiedGeoLookup() {
                geoLookupData = new GeoLookupData() {
                    ContinentCode = geo.continent_code,
                    ContinentName = geo.continent_name,
                    CountryCode = geo.country_code,
                    CountryName = geo.country_name,
                    RegionCode = geo.region_code,
                    RegionName = geo.region_name,
                    City = geo.city,
                    Zip = geo.zip,
                    Latitude = geo.latitude,
                    Longitude = geo.longitude,
                    CountryFlag = geo.location.country_flag
                }
            };
            return sgl;
        }
    }
}
