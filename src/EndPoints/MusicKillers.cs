using PoLaKoSz.MusicFM.DataAccessLayer.Web;
using PoLaKoSz.MusicFM.Models;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Access every MusicKiller DJ's tracklist within this object.
    /// </summary>
    public class MusicKillers
    {
        /// <summary>
        /// Be careful with these tracklists because it can contains
        /// interesting <see cref="Music"/>s. Non null object.
        /// </summary>
        public MusicKiller TracklistFrom { get; }



        /// <summary>
        /// Initialize an instance to access every MusicKiller
        /// DJ's tracklist.
        /// </summary>
        /// <param name="httpClient">Non null object to access the web.</param>
        public MusicKillers(IHttpClient httpClient)
        {
            TracklistFrom = new MusicKiller("musorvezeto", httpClient);
        }
    }
}
