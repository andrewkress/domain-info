using System;

namespace domain_info.Models {
    public class IPStack {
            public string ip { get; set; }
            public string type { get; set; }
            public string continent_code { get; set; }
            public string continent_name { get; set; }
            public string country_code { get; set; }
            public string country_name { get; set; }
            public string region_code { get; set; }
            public string region_name { get; set; }
            public string city { get; set; }
            public string zip { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public Location location { get; set; }
        }
}
