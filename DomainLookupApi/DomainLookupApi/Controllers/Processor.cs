
namespace DomainLookupApi.Controllers
{
    using DomainLookupApi.Model;

    /// <summary>
    /// Handles the process of calliing the correct lookup.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Processor<T>
        where T : IDomainInfo, new()
    {
        private string ip { get; set; }
        private T handler { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Processor{T}"/> class.
        /// </summary>
        /// <param name="ip">The ip.</param>
        public Processor(string ip)
        {
            this.ip = ip;
            this.handler = new T(); //default(T);
        }


        /// <summary>
        /// Lookups the specified ip.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <returns></returns>
        public IDomainInfoModel Lookup()
        {
            if (!this.handler.ValidateIP(this.ip) && !this.handler.ValidateDomain(this.ip))
            {
                return null;
            }

            return this.handler.GetDomainInfo(this.ip);
        }
    }
}