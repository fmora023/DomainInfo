
namespace DomainLookupApi.Model
{
    using System;
    using System.Net;

    /// <summary>
    /// Reverse DNS implementation.
    /// </summary>
    /// <seealso cref="DomainLookupApi.Model.IDomainInfo" />
    public class ReverseDNS : IDomainInfo
    {
        public IDomainInfoModel GetDomainInfo(string ip)
        {
            try
            {
                var hostIP = IPAddress.Parse(ip);
                var hostInfo = Dns.GetHostEntry(hostIP);
                if(hostInfo == null)
                {
                    return null;
                }

                var result = new ReverseDNSModel();
                result.AddressList = hostInfo.AddressList;
                result.Aliases = hostInfo.Aliases;
                result.HostName = hostInfo.HostName;

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Source : " + e.Source);
                return null;
            }
        }

        public bool ValidateDomain(string domainName)
        {
            return false;
        }

        public bool ValidateIP(string ip)
        {
            return IPAddress.TryParse(ip, out var address);
        }
    }
}
