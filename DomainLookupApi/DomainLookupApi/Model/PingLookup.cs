
namespace DomainLookupApi.Model
{
    using System;
    using System.Net;
    using System.Net.NetworkInformation;

    /// <summary>
    /// Get the information by ping.
    /// </summary>
    public class PingLookup : IDomainInfo
    {
        /// <summary>
        /// Gets the domain information.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <returns></returns>
        public IDomainInfoModel GetDomainInfo(string ip)
        {
            var ping = new Ping();
            var pingReply = ping.Send(ip);

            if (pingReply.Status == IPStatus.Success)
            {
                var result = new PingLookupModel();
                result.Address = pingReply.Address;
                result.RoundtripTime = pingReply.RoundtripTime;
            }

            return null;

        }

        public bool ValidateDomain(string domainName)
        {
            return Uri.CheckHostName(domainName) != UriHostNameType.Unknown;
        }

        public bool ValidateIP(string ip)
        {
            return IPAddress.TryParse(ip, out var address);
        }
    }
}
