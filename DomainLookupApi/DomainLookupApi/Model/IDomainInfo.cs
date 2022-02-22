
namespace DomainLookupApi.Model
{
    /// <summary>
    /// Interface to generalize domain info generation.
    /// </summary>
    public interface IDomainInfo
    {
        /// <summary>
        /// Gets the domain information.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <returns></returns>
        IDomainInfoModel GetDomainInfo(string ip);

        /// <summary>
        /// Validates the domain.
        /// </summary>
        /// <param name="domainName">Name of the domain.</param>
        /// <returns>
        ///     true if valid domain
        ///     false if invalid domain
        /// </returns>
        bool ValidateDomain(string domainName);

        /// <summary>
        /// Validates the ip.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <returns>
        ///     true if valid domain
        ///     false if invalid domain
        /// </returns>
        bool ValidateIP(string ip);
    }
}
