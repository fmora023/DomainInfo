
namespace DomainLookupApi.Model
{
    using System.Net;

    /// <summary>
    /// Model for ping.
    /// </summary>
    /// <seealso cref="DomainLookupApi.Model.IDomainInfoModel" />
    public class PingLookupModel : IDomainInfoModel
    {
        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public IPAddress Address { get; set; }

        /// <summary>
        /// Gets the roundtrip time.
        /// </summary>
        /// <value>
        /// The roundtrip time.
        /// </value>
        public long RoundtripTime { get; set; }
    }
}
