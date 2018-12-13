using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using PoLaKoSz.MusicFM.DataAccessLayer.Web;

namespace PoLaKoSz.MusicFM.Tests.Integration
{
    /// <summary>
    /// Mock the HttpClient. Use the ResponseFromServer property to change what
    /// should be returned from the fase server.
    /// </summary>
    class HttpClientMock : IHttpClient
    {
        public string ResponseFromServer { get; set; }
        public Uri LastCalledURL { get; private set; }
        public Uri BaseAddress { get; }



        public HttpClientMock()
        {
            ResponseFromServer = "";

            BaseAddress = new Uri("https://api.deezer.com/");
        }



        public Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            LastCalledURL = requestUri;

            var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(ResponseFromServer)
            };

            return Task.Run(() => httpResponse);
        }
    }
}
