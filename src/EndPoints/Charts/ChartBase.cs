using HtmlAgilityPack;
using PoLaKoSz.MusicFM.DataAccessLayer.Web;
using PoLaKoSz.MusicFM.Models;
using PoLaKoSz.MusicFM.Parsers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Base class for every chart.
    /// </summary>
    public abstract class ChartBase : EndPoint
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="chartType">20 or 50.</param>
        /// <param name="httpClient">Non null object.</param>
        public ChartBase(int chartType, IHttpClient httpClient)
            : base($"chart/top{chartType}", httpClient) { }



        /// <summary>
        /// Get the tracklist from the page.
        /// </summary>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        public async Task<List<Track>> All()
        {
            return await All(new Cleaner());
        }

        /// <summary>
        /// Get the tracklist from the page.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        public async Task<List<Track>> All(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("all");

            return ChartsParser.Process(sourceCode, cleaner);
        }
    }
}
