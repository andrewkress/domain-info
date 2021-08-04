using System;
using Xunit;
using domain_info.Controllers;

namespace domain_info.tests {

    public class MethodTests {

        private QueryController qc;

        public MethodTests() {
            qc = new QueryController(null);
        }

        [Theory]
        [InlineData("validdomain.com", true)]
        [InlineData("invaliddomain", false)]
        [InlineData("192.168.1.1.1", true)] // technically a valid domain, not IP
        [InlineData("300.155.1.100", true)] // technically a valid domain, not IP
        [InlineData("300.100", true)] // technically a valid domain, not IP
        [InlineData("api.domain-info.ml", true)]
        public void TestDomainFormatting(String domain, bool valid) {
            (bool actual, bool isDomain, bool isIp) = qc.isValidDomainOrIp(domain);
            Assert.Equal(valid, actual);
            Assert.Equal(isDomain, actual);
            Assert.False(isIp);
        }

        [Theory]
        [InlineData("123.155.100.100", true)]
        [InlineData("123.155.1.100", true)]
        [InlineData("123", false)]
        public void TestIPFormatting(String ip, bool valid) {
            (bool actual, bool isDomain, bool isIp) = qc.isValidDomainOrIp(ip);
            Assert.Equal(valid, actual);
            Assert.False(isDomain);
            Assert.Equal(isIp, actual);
        }
    }
}
