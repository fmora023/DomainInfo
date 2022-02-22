
namespace DomainLookupApi.Model
{
    /// <summary>
    /// GeoIP model.
    /// </summary>
    /// <seealso cref="DomainLookupApi.Model.IDomainInfoModel" />
    public class GeoIPModel : IDomainInfoModel
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the iso code.
        /// </summary>
        /// <value>
        /// The iso code.
        /// </value>
        public string ISOCode { get; set; }

        /// <summary>
        /// Gets the names from locale codes to the name in that locale.
        /// </summary>
        /// <value>
        /// The names.
        /// </value>
        public string Names { get; set; }
    }
}
