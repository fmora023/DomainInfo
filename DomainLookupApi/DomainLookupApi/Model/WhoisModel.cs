
namespace DomainLookupApi.Model
{
    /// <summary>
    /// Whois.Net model definition
    /// </summary>
    /// <seealso cref="DomainLookupApi.Model.IDomainInfoModel" />
    public class WhoisModel : IDomainInfoModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the raw.
        /// </summary>
        /// <value>
        /// The raw.
        /// </value>
        public string Raw { get; set; }

        /// <summary>
        /// Gets or sets the responded servers.
        /// </summary>
        /// <value>
        /// The responded servers.
        /// </value>
        public string[] RespondedServers { get; set; }
    }
}
