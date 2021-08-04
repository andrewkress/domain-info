using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class SimplifiedGeoLookup {
        public GeoLookupData geoLookupData { get; set; }
    }

    public class GeoLookupData {
        public String ContinentCode { get; set; }
        public String ContinentName { get; set; }
        public String CountryCode { get; set; }
        public String CountryName { get; set; }
        public String RegionCode { get; set; }
        public String RegionName { get; set; }
        public String City { get; set; }
        public String Zip { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public String CountryFlag { get; set; }
    }
}
