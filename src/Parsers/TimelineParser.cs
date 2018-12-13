using HtmlAgilityPack;
using PoLaKoSz.MusicFM.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PoLaKoSz.MusicFM.Parsers
{
    internal static class TimelineParser
    {
        /// <summary>
        /// Extract <see cref="Track"/>s from the JSON.
        /// </summary>
        /// <param name="json">Non null string.</param>
        /// <param name="clean"></param>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        internal static List<Track> Process(string json, ICleaner clean)
        {
            // If this not here, HtmlAgilityPack can't work
            json = UnicodeCharactersToASCII(json).Replace(@"\/", "/");

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(json);

            var songNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='now-playing-small clearfix' or @class='now-playing-big clearfix']");

            if (songNodes == null)
                throw new NodeNotFoundException("Couldn't find songs with the given XPath!");

            List<Track> tracklist = new List<Track>();

            ExtractTracks(clean, songNodes, tracklist);

            return tracklist;
        }


        private static string UnicodeCharactersToASCII(string sourceCode)
        {
            return Regex.Replace(sourceCode, @"\\u(?<Value>[a-zA-Z0-9]{4})",
                m => { return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString(); });
        }

        private static void ExtractTracks(ICleaner clean, HtmlNodeCollection songNodes, List<Track> tracklist)
        {
            for (int i = 0; i < songNodes.Count; i++)
            {
                HtmlNode artistNode = songNodes[i].SelectSingleNode(".//div[@class='artist']");
                HtmlNode titleNode = songNodes[i].SelectSingleNode(".//div[@class='song']");

                if (artistNode == null)
                    throw new NodeNotFoundException($"Couldn't find song's author node with the given XPath at index: {i}!");

                if (titleNode == null)
                    throw new NodeNotFoundException($"Couldn't find song's title node with the given XPath at index: {i}!");

                if (clean.IsNotArtist(artistNode.InnerText))
                    continue;

                string artistName = clean.ArtistName(artistNode.InnerText);

                tracklist.Add(new Track(artistName, titleNode.InnerText));
            }
        }
    }
}
