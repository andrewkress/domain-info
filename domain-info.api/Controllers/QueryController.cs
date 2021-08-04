using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using domain_info.Models;
using domain_info.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace domain_info.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueryController : ControllerBase {

        private string _reverseIpApiKey = null;
        private string _ipStackApiKey = null;
        private string _virusTotalApiKey = null;
        private string[] allServices = new string[] { "reverseip", "whois", "geo", "virustotal" };
        private static HttpClient httpClient = new HttpClient();

        public QueryController(IConfiguration config) {
            _reverseIpApiKey = config["whoisxmlapi"];
            _ipStackApiKey = config["ipstack"];
            _virusTotalApiKey = config["virustotal"];
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(String domainOrIp, [FromQuery] String[] services = null) {
            
            (bool isValid, bool isDomain, bool isIp) = isValidDomainOrIp(domainOrIp);
            if (!isValid) {
                return StatusCode(422);
            }
            if(services?.Length == 0) {
                services = allServices;
            }

            List<DomainInfo> results = new List<DomainInfo>();
            List<Task> apiCalls = new List<Task>();

            // this Func allows us to collect results in a list
            Func<String, String, String, Task> callApiAsync = async (String url, String service, String xApi) => {
                if(String.IsNullOrWhiteSpace(xApi)) {
                    httpClient.DefaultRequestHeaders.Remove("x-apikey");
                } else {
                    httpClient.DefaultRequestHeaders.Add("x-apikey", xApi);
                }
                var result = await httpClient.GetAsync(url);
                String contentText = await result.Content.ReadAsStringAsync();
                results.Add(new DomainInfo() {
                    ServiceName = service,
                    ServiceResult = contentText
                });
            };


            Array.ForEach(services, (service) => {
                if(service.Equals("whois") && isDomain) {
                    apiCalls.Add(callApiAsync($"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey={_reverseIpApiKey}&domainName={domainOrIp}&outputFormat=json", service, null));
                } else if(service.Equals("geo") && isIp) {
                    apiCalls.Add(callApiAsync($"http://api.ipstack.com/{domainOrIp}?access_key={_ipStackApiKey}&format=1", service, null));
                } else if (service.Equals("reverseip") && isIp) {
                    apiCalls.Add(callApiAsync($"https://reverse-ip.whoisxmlapi.com/api/v1?apiKey={_reverseIpApiKey}&ip={domainOrIp}", service, null));
                } else if (service.Equals("virustotal") && isIp) {
                    apiCalls.Add(callApiAsync($"https://www.virustotal.com/api/v3/ip_addresses/{domainOrIp}", service, _virusTotalApiKey));
                } else if (service.Equals("virustotal") && isDomain) {
                    apiCalls.Add(callApiAsync($"https://www.virustotal.com/api/v3/domains/{domainOrIp}", service, _virusTotalApiKey));
                }
                // invalid service names will be skipped
            });
            // wait for all async tasks to complete
            await Task.WhenAll(apiCalls.ToArray());

            List<Object> parsedResults = new List<Object>();
            foreach(DomainInfo di in results) {
                IServiceParser sp = ServiceParserFactory.GetParserForService(di.ServiceName);
                parsedResults.Add(sp.ParseDomainInfo(di));
            }
            return Ok(parsedResults);
        }

        internal (bool, bool, bool) isValidDomainOrIp(String domainOrIp) {

            UriHostNameType hostNameType = Uri.CheckHostName(domainOrIp);
            if(hostNameType == UriHostNameType.IPv4) {
                // check for 3 periods
                Regex regex = new Regex(@"\d+\.\d+\.\d+\.\d+");
                if (regex.IsMatch(domainOrIp)) {
                    return (true, false, true);
                }
            } else if (hostNameType == UriHostNameType.Dns) {
                if (domainOrIp.Contains(".")) {
                    return (true, true, false);
                }
            }
            // string passed in is not what we would consider a valid domain or ip address
            return (false, false, false);
        }
    }
}
