using System;

namespace domain_info.Models {
    public class Data {
        public Attributes attributes { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public Links links { get; set; }
    }

    public class Links {
        public string self { get; set; }
    }
}
