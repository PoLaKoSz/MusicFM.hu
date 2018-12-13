using System.Net.Http;

namespace PoLaKoSz.MusicFM.DataAccessLayer.Web
{
    /// <summary>
    /// Built-in client to access the web.
    /// </summary>
    public class HttpClient : System.Net.Http.HttpClient, IHttpClient
    {
        /// <summary>
        /// Initialize an instance.
        /// </summary>
        public HttpClient()
            : base(new HttpClientHandler(), disposeHandler: true)
        {
            DefaultRequestHeaders.Add("Accept", "*/*");
            DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Android 4.1.2; Mobile; rv:60.0) Gecko/60.0 Firefox/60.0");
        }
    }
}
