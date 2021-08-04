using System;

namespace domain_info.Models {
    public class ReverseIP {
        public string current_page { get; set; }
        public int size { get; set; }
        public Result[] result { get; set; }
    }
}
