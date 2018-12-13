using PoLaKoSz.MusicFM.DataAccessLayer.Web;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Class to access the TOP20 chart.
    /// </summary>
    public class Top20Chart : ChartBase
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="httpClient">Not null object.</param>
        public Top20Chart(IHttpClient httpClient)
            : base(20, httpClient) { }
    }
}
