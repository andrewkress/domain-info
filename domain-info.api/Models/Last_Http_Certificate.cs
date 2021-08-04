using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain_info.Models {
    public class Last_Https_Certificate {
        public Public_Key public_key { get; set; }
        public string thumbprint_sha256 { get; set; }
        public object[] tags { get; set; }
        public string signature_algorithm { get; set; }
        public Subject subject { get; set; }
        public Validity validity { get; set; }
        public string version { get; set; }
        public Extensions extensions { get; set; }
        public Cert_Signature cert_signature { get; set; }
        public string serial_number { get; set; }
        public string thumbprint { get; set; }
        public Issuer issuer { get; set; }
        public int size { get; set; }
    }

    public class Public_Key {
        public Rsa rsa { get; set; }
        public string algorithm { get; set; }
    }

    public class Rsa {
        public int key_size { get; set; }
        public string modulus { get; set; }
        public string exponent { get; set; }
    }

    public class Subject {
        public string CN { get; set; }
    }

    public class Validity {
        public string not_after { get; set; }
        public string not_before { get; set; }
    }

    public class Extensions {
        public string[] certificate_policies { get; set; }
        public string[] extended_key_usage { get; set; }
        public object[] tags { get; set; }
        public string[] subject_alternative_name { get; set; }
        public Authority_Key_Identifier authority_key_identifier { get; set; }
        public Ca_Information_Access ca_information_access { get; set; }
        public string subject_key_identifier { get; set; }
        public string[] key_usage { get; set; }
        public string _13614111129242 { get; set; }
        public bool CA { get; set; }
    }

    public class Authority_Key_Identifier {
        public string keyid { get; set; }
    }

    public class Ca_Information_Access {
        public string CAIssuers { get; set; }
        public string OCSP { get; set; }
    }

    public class Cert_Signature {
        public string signature_algorithm { get; set; }
        public string signature { get; set; }
    }

    public class Issuer {
        public string C { get; set; }
        public string CN { get; set; }
        public string O { get; set; }
    }
}
