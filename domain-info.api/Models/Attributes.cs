using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class Attributes {
        public Last_Dns_Records[] last_dns_records { get; set; }
        public string jarm { get; set; }
        public string whois { get; set; }
        public int last_https_certificate_date { get; set; }
        public object[] tags { get; set; }
        public Popularity_Ranks popularity_ranks { get; set; }
        public int last_dns_records_date { get; set; }
        public Last_Analysis_Stats last_analysis_stats { get; set; }
        public int creation_date { get; set; }
        public int whois_date { get; set; }
        public int reputation { get; set; }
        public string registrar { get; set; }
        public Last_Analysis_Results last_analysis_results { get; set; }
        public int last_update_date { get; set; }
        public int last_modification_date { get; set; }
        public Last_Https_Certificate last_https_certificate { get; set; }
        public Categories categories { get; set; }
        public Total_Votes total_votes { get; set; }
    }

    public class Popularity_Ranks {
    }

    public class Categories {
    }


    public class Total_Votes {
        public int harmless { get; set; }
        public int malicious { get; set; }
    }
}
