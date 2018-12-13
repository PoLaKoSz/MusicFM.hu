using PoLaKoSz.MusicFM.DataAccessLayer.Web;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Container to access any chart on MusicFM.hu.
    /// </summary>
    public class Charts
    {
        /// <summary>
        /// Gets access to the <see cref="Top20Chart"/> instance.
        /// </summary>
        public Top20Chart Top20 { get; }

        /// <summary>
        /// Gets access to the <see cref="Top50Chart"/> instance.
        /// </summary>
        public Top50Chart Top50 { get; }



        /// <summary>
        /// Initialize a new instance to access the charts.
        /// </summary>
        /// <param name="httpClient">Non null object.</param>
        public Charts(IHttpClient httpClient)
        {
            Top20 = new Top20Chart(httpClient);
            Top50 = new Top50Chart(httpClient);
        }
    }
}
