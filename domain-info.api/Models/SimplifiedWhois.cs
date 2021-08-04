using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class SimplifiedWhois {
        public WhoisData whoisData { get; set; }
    }

    public class WhoisData {

        public String DomainName { get; set; }
        public String RegistrarName { get; set; }
        public String CreatedDate { get; set; }
        public String UpdatedDate { get; set; }
        public String ExpiresDate { get; set; }
        public String RegistrantName { get; set; }
        public String RegistrantOrganization { get; set; }
        public String RegistrantStreet { get; set; }
        public String RegistrantCity { get; set; }
        public String RegistrantState { get; set; }
        public String RegistrantPostalCode { get; set; }
        public String RegistrantCountry { get; set; }
        public String RegistrantCountryCode { get; set; }
        public String RegistrantTelephone { get; set; }
        public String RegistrantTelephoneExt { get; set; }
    }
}
