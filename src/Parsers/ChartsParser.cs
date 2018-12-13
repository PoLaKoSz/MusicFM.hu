using HtmlAgilityPack;
using PoLaKoSz.MusicFM.Models;
using System.Collections.Generic;

namespace PoLaKoSz.MusicFM.Parsers
{
    internal static class ChartsParser
    {
        /// <summary>
        /// Extract the <see cref="Track"/>s from the HTML.
        /// </summary>
        /// <param name="sourceCode">Non null string.</param>
        /// <param name="clean">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        public static List<Track> Process(string sourceCode, ICleaner clean)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(sourceCode);

            var songNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='content']/div[@class='chart-wrapper']/div[@class='chart-content-wrapper']/div[@class='chart-content-block-sub']");

            if (songNodes == null)
                throw new NodeNotFoundException("Couldn't find songs with the given XPath!");

            var tracks = new List<Track>();

            for (int i = 0; i < songNodes.Count; i++)
            {
                HtmlNode artistNode = songNodes[i].SelectSingleNode("./div[@class='chart-content-metadata-sub']/div[@class='chart-content-author-sub']/a"),
                          titleNode = songNodes[i].SelectSingleNode("./div[@class='chart-content-metadata-sub']/div[@class='chart-content-title-sub']/a");

                if (artistNode == null)
                    throw new NodeNotFoundException($"Couldn't find song's author node with the given XPath at index: {i}!");

                if (titleNode == null)
                    throw new NodeNotFoundException($"Couldn't find song's title node with the given XPath at index: {i}!");

                string artistName = clean.ArtistName(artistNode.InnerText);

                tracks.Add(new Track(artistName, titleNode.InnerText));
            }

            return tracks;
        }
    }
}
