
namespace DomainLookupApi.Model
{
    using global::Whois.NET;
    using System;
    using System.Net;

    public class Whois : IDomainInfo
    {
        /// <inheritdoc/>
        public IDomainInfoModel GetDomainInfo(string ip)
        {
            var model = new WhoisModel();
            var response = WhoisClient.Query(ip);
            if (response == null)
            {
                return null;
            }

            model.Name = response.OrganizationName;
            model.Raw = response.Raw;
            model.RespondedServers = response.RespondedServers;

            return model;
        }

        /// <inheritdoc/>
        public bool ValidateDomain(string domainName)
        {
            return Uri.CheckHostName(domainName) != UriHostNameType.Unknown;
        }

        /// <inheritdoc/>
        public bool ValidateIP(string ip)
        {
            return IPAddress.TryParse(ip, out var address);
        }
    }
}
