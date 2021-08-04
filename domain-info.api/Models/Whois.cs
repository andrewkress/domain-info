using System;

namespace domain_info.Models {

    public class Whois {
        public Whoisrecord WhoisRecord { get; set; }
    }

    public class Whoisrecord {
        public string domainName { get; set; }
        public int parseCode { get; set; }
        public Audit audit { get; set; }
        public string registrarName { get; set; }
        public string registrarIANAID { get; set; }
        public string dataError { get; set; }
        public Registrydata registryData { get; set; }
        public string contactEmail { get; set; }
        public string domainNameExt { get; set; }
        public int estimatedDomainAge { get; set; }
    }

    public class Audit {
        public string createdDate { get; set; }
        public string updatedDate { get; set; }
    }

    public class Registrydata {
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public DateTime expiresDate { get; set; }
        public Registrant registrant { get; set; }
        public Administrativecontact administrativeContact { get; set; }
        public Technicalcontact technicalContact { get; set; }
        public string domainName { get; set; }
        public Nameservers nameServers { get; set; }
        public string status { get; set; }
        public string rawText { get; set; }
        public int parseCode { get; set; }
        public string header { get; set; }
        public string strippedText { get; set; }
        public string footer { get; set; }
        public Audit1 audit { get; set; }
        public string customField1Name { get; set; }
        public string customField1Value { get; set; }
        public string registrarName { get; set; }
        public string registrarIANAID { get; set; }
        public string createdDateNormalized { get; set; }
        public string updatedDateNormalized { get; set; }
        public string expiresDateNormalized { get; set; }
        public string customField2Name { get; set; }
        public string customField3Name { get; set; }
        public string customField2Value { get; set; }
        public string customField3Value { get; set; }
        public string whoisServer { get; set; }
    }

    public class Registrant {
        public string name { get; set; }
        public string organization { get; set; }
        public string street1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string telephone { get; set; }
        public string telephoneExt { get; set; }
        public string fax { get; set; }
        public string faxExt { get; set; }
        public string rawText { get; set; }
    }

    public class Administrativecontact {
        public string name { get; set; }
        public string organization { get; set; }
        public string street1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string telephone { get; set; }
        public string telephoneExt { get; set; }
        public string fax { get; set; }
        public string faxExt { get; set; }
        public string rawText { get; set; }
    }

    public class Technicalcontact {
        public string name { get; set; }
        public string organization { get; set; }
        public string street1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string telephone { get; set; }
        public string telephoneExt { get; set; }
        public string fax { get; set; }
        public string faxExt { get; set; }
        public string rawText { get; set; }
    }

    public class Nameservers {
        public string rawText { get; set; }
        public string[] hostNames { get; set; }
        public object[] ips { get; set; }
    }

    public class Audit1 {
        public string createdDate { get; set; }
        public string updatedDate { get; set; }
    }

}
