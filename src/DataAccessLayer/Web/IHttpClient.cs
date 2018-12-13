using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.DataAccessLayer.Web
{
    /// <summary>
    /// Implementation to access the web.
    /// </summary>
    public interface IHttpClient
    {
        /// <summary>
        /// Send a GET request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">The requestUri was null.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS
        /// failure, server certificate validation or timeout.</exception>
        Task<HttpResponseMessage> GetAsync(Uri requestUri);
    }
}
