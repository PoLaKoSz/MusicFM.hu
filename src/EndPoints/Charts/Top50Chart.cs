using PoLaKoSz.MusicFM.DataAccessLayer.Web;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Class to access the TOP50 chart.
    /// </summary>
    public class Top50Chart : ChartBase
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="httpClient">Not null object.</param>
        public Top50Chart(IHttpClient httpClient)
            : base(50, httpClient) { }
    }
}
