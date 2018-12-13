using PoLaKoSz.MusicFM.DataAccessLayer.Web;
using PoLaKoSz.MusicFM.EndPoints;

namespace PoLaKoSz.MusicFM
{
    /// <summary>
    /// This class is the main entry point for the library.
    /// </summary>
    public class MusicFM
    {
        /// <summary>
        /// Gets the <see cref="EndPoints.HomePage"/> instance.
        /// </summary>
        public HomePage HomePage { get; }

        /// <summary>
        /// Gets the <see cref="EndPoints.Charts"/> instance.
        /// </summary>
        public Charts Charts { get; }

        /// <summary>
        /// Gets the <see cref="MusicKillers"/> instance.
        /// </summary>
        public MusicKillers MusicKillers { get; set; }



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public MusicFM()
            : this(new HttpClient()) { }

        /// <summary>
        /// Initialize a new instance with a custom
        /// <see cref="IHttpClient"/>.
        /// </summary>
        /// <param name="httpClient">Not null object.</param>
        public MusicFM(IHttpClient httpClient)
        {
            HomePage     = new HomePage(httpClient);
            Charts       = new Charts(httpClient);
            MusicKillers = new MusicKillers(httpClient);
        }
    }
}
