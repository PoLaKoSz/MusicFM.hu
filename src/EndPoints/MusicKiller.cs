using PoLaKoSz.MusicFM.DataAccessLayer.Web;
using PoLaKoSz.MusicFM.Models;
using PoLaKoSz.MusicFM.Parsers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace PoLaKoSz.MusicFM.EndPoints
{
    /// <summary>
    /// Access every MusicKiller DJ's tracklist within this object.
    /// </summary>
    public class MusicKiller : EndPoint
    {
        /// <summary>
        /// Initialize an instance to access every MusicKiller
        /// DJ's tracklist.
        /// </summary>
        /// <param name="endPoint">Non null string representing the beginning of the URL.</param>
        /// <param name="httpClient">Non null object to access the web.</param>
        public MusicKiller(string endPoint, IHttpClient httpClient)
            : base(endPoint, httpClient) { }



        /// <summary>
        /// Get Antonyo's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Antonyo()
        {
            return await Antonyo(new Cleaner());
        }

        /// <summary>
        /// Get _______________________'s tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Antonyo(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("antonyo");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Armin Van Buuren's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> ArminVanBuuren()
        {
            return await ArminVanBuuren(new Cleaner());
        }

        /// <summary>
        /// Get Armin Van Buuren's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> ArminVanBuuren(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("armin-van-buuren");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get DannyL's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DannyL()
        {
            return await DannyL(new Cleaner());
        }

        /// <summary>
        /// Get DannyL's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DannyL(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("dannyl");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Deep Lison's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DeepLison()
        {
            return await DeepLison(new Cleaner());
        }

        /// <summary>
        /// Get Deep Lison's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DeepLison(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("deep-lison");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get DJ Nara's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DjNara()
        {
            return await DjNara(new Cleaner());
        }

        /// <summary>
        /// Get DJ Nara's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DjNara(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("dj-nara");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Don Diablo's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DonDiablo()
        {
            return await DonDiablo(new Cleaner());
        }

        /// <summary>
        /// Get DonDiablo's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> DonDiablo(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("don-diablo");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Hardwell's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Hardwell()
        {
            return await Hardwell(new Cleaner());
        }

        /// <summary>
        /// Get Hardwell's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Hardwell(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("hardwell");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Jovan's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Jovan()
        {
            return await Jovan(new Cleaner());
        }

        /// <summary>
        /// Get Jovan's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Jovan(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("jovan");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Lauer's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Lauer()
        {
            return await Lauer(new Cleaner());
        }

        /// <summary>
        /// Get Lauer's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Lauer(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("lauer");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Newl's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Newl()
        {
            return await Newl(new Cleaner());
        }

        /// <summary>
        /// Get Newl's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Newl(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("newl");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Nigel Stately's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> NigelStately()
        {
            return await NigelStately(new Cleaner());
        }

        /// <summary>
        /// Get Nigel Stately's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> NigelStately(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("nigel-stately");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Oliver Heldens's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> OliverHeldens()
        {
            return await OliverHeldens(new Cleaner());
        }

        /// <summary>
        /// Get Oliver Heldens's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> OliverHeldens(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("oliver-heldens");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Pixa's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Pixa()
        {
            return await Pixa(new Cleaner());
        }

        /// <summary>
        /// Get Pixa's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Pixa(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("pixa");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Tiësto's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Tiesto()
        {
            return await Tiesto(new Cleaner());
        }

        /// <summary>
        /// Get Tiesto's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Tiesto(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("tiesto");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Willcox's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Willcox()
        {
            return await Willcox(new Cleaner());
        }

        /// <summary>
        /// Get Willcox's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Willcox(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("willcox");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Yamina's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Yamina()
        {
            return await Yamina(new Cleaner());
        }

        /// <summary>
        /// Get Yamina's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Yamina(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("yamina");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }

        /// <summary>
        /// Get Zoohacker's tracklist cleaned with the default rules.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Zoohacker()
        {
            return await Zoohacker(new Cleaner());
        }

        /// <summary>
        /// Get Zoohacker's tracklist with a custom cleaning method.
        /// </summary>
        /// <param name="cleaner">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<List<Music>> Zoohacker(ICleaner cleaner)
        {
            string sourceCode = await base.GetAsync("zoohacker");

            return MusicKillerParser.Process(sourceCode, cleaner);
        }
    }
}
