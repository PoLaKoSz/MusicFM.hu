using HtmlAgilityPack;
using PoLaKoSz.MusicFM.DataAccessLayer.Web;
using PoLaKoSz.MusicFM.Models;
using PoLaKoSz.MusicFM.Parsers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Container to access the main page of the MusicFM.hu.
    /// </summary>
    public class HomePage : EndPoint
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="httpClient">Not null object.</param>
        public HomePage(IHttpClient httpClient)
            : base("", httpClient) { }



        /// <summary>
        /// Get a clean tracklist from the timeline.
        /// </summary>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        public async Task<List<Track>> Timeline()
        {
            return await Timeline(new Cleaner());
        }

        /// <summary>
        /// Get the tracklist from the timeline with a
        /// custom cleaning mechanism.
        /// </summary>
        /// <param name="cleaner">Non null object which responsible
        /// to clean the parsed input.</param>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        public async Task<List<Track>> Timeline(ICleaner cleaner)
        {
            string json = await base.GetAsync("musor/api/songs/0/999");

            return TimelineParser.Process(json, cleaner);
        }
    }
}
