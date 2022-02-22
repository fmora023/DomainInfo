
namespace DomainLookupApi.Model
{
    using System.Net;

    /// <summary>
    /// Model for Reverse dns.
    /// </summary>
    /// <seealso cref="DomainLookupApi.Model.IDomainInfoModel" />
    public class ReverseDNSModel : IDomainInfoModel
    {
        /// <summary>
        /// Gets or sets the address list.
        /// </summary>
        /// <value>
        /// The address list.
        /// </value>
        public IPAddress[] AddressList { get; set; }

        /// <summary>
        /// Gets or sets the aliases.
        /// </summary>
        /// <value>
        /// The aliases.
        /// </value>
        public string[] Aliases { get; set; }

        /// <summary>
        /// Gets or sets the name of the host.
        /// </summary>
        /// <value>
        /// The name of the host.
        /// </value>
        public string HostName { get; set; }
    }
}
