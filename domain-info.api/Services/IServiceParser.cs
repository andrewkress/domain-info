using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain_info.Models;

namespace domain_info.Services {
    public interface IServiceParser {
        Object ParseDomainInfo(DomainInfo domainInfo);
    }
}
