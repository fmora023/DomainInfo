

namespace DomainLookupApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using DomainLookupApi.Model;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class LookupController : ControllerBase
    {
        private static readonly HashSet<string> defaultSearchers = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
        {
            "GeoIP", "WhoIs", "ReverseDNS", "Ping"
        };

        /// <summary>
        /// Lookups the specified ip.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <param name="searchers">The searchers.</param>
        /// <returns></returns>
        [HttpPost]
        public IEnumerable<IDomainInfoModel> Lookup(string ip, HashSet<string> searchers)
        {
            if (searchers.Count == 0)
            {
                searchers = defaultSearchers;
            }

            if (string.IsNullOrEmpty(ip))
            {
                return null;
            }

            var result = new List<IDomainInfoModel>();

            foreach (var searcher in searchers)
            {
                // this code should be changed for threads
                switch(searcher)
                {
                    case "GeoIP":
                        var geoProcessor = new Processor<GeoIP>(ip);
                        result.Add(geoProcessor.Lookup());
                        break;
                    case "WhoIs":
                        var wProcessor = new Processor<Whois>(ip); 
                        result.Add(wProcessor.Lookup());
                        break;
                    case "ReverseDNS":
                        var reverseProcessor = new Processor<ReverseDNS>(ip);
                        result.Add(reverseProcessor.Lookup());
                        break;
                    case "Ping":
                        var pingProcessor = new Processor<PingLookup>(ip);
                        result.Add(pingProcessor.Lookup());
                        break;
                }
            }

            return result;
        }
    }
}
