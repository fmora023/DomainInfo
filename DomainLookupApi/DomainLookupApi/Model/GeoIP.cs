
namespace DomainLookupApi.Model
{
    using System.Net;
    using MaxMind.GeoIP2;

    /// <summary>
    /// Generalization using GeoIp Service
    /// </summary>
    /// <seealso cref="DomainLookupApi.Model.IDomainInfo" />
    public class GeoIP : IDomainInfo
    {
        private static readonly int UseId = 679646;
        private static readonly string Key = "43lwDAZPJsKm4H3U";
        private static readonly string Host = "geolite.info";

        /// <inheritdoc/>
        public IDomainInfoModel GetDomainInfo(string ip)
        {
            var result = new GeoIPModel();

            using (var client = new WebServiceClient(GeoIP.UseId, GeoIP.Key, host: GeoIP.Host))
            {
                if (client == null)
                {
                    return null;
                }

                // Do the lookup
                var response = client.Country(ip);

                result.Country = response.Country.Name;         // 'US'
                result.ISOCode = response.Country.IsoCode;      // 'United States'
                result.Names = response.Country.Names["zh-CN"]; // '美国'
            }

            return result;
        }

        /// <inheritdoc/>
        public bool ValidateDomain(string domainName)
        {
            return false; // current license don't includes domain.
        }

        /// <inheritdoc/>
        public bool ValidateIP(string ip)
        {
            return IPAddress.TryParse(ip, out var address);
        }
    }
}
