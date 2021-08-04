using System;
using Newtonsoft.Json;
using domain_info.Models;

namespace domain_info.Services {
    public class WhoisServiceParser : IServiceParser {
        public object ParseDomainInfo(DomainInfo domainInfo) {
            Whois whois = JsonConvert.DeserializeObject<Whois>(domainInfo.ServiceResult);

            SimplifiedWhois sw = new SimplifiedWhois() {
                whoisData = new WhoisData() {
                    DomainName = whois.WhoisRecord.registrarName,
                    RegistrarName = whois.WhoisRecord.registrarName,
                    CreatedDate = whois.WhoisRecord.registryData.createdDateNormalized,
                    UpdatedDate = whois.WhoisRecord.registryData.updatedDateNormalized,
                    ExpiresDate = whois.WhoisRecord.registryData.expiresDateNormalized,
                    RegistrantName = whois.WhoisRecord.registryData.registrant?.name,
                    RegistrantOrganization = whois.WhoisRecord.registryData.registrant?.organization,
                    RegistrantStreet = whois.WhoisRecord.registryData.registrant?.street1,
                    RegistrantCity = whois.WhoisRecord.registryData.registrant?.city,
                    RegistrantState = whois.WhoisRecord.registryData.registrant?.state,
                    RegistrantPostalCode = whois.WhoisRecord.registryData.registrant?.postalCode,
                    RegistrantCountry = whois.WhoisRecord.registryData.registrant?.country,
                    RegistrantCountryCode = whois.WhoisRecord.registryData.registrant?.countryCode,
                    RegistrantTelephone = whois.WhoisRecord.registryData.registrant?.telephone,
                    RegistrantTelephoneExt = whois.WhoisRecord.registryData.registrant?.telephoneExt
                }
            };
            return sw;
        }
    }
}
