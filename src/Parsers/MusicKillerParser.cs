using HtmlAgilityPack;
using PoLaKoSz.MusicFM.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PoLaKoSz.MusicFM.Parsers
{
    internal static class MusicKillerParser
    {
        /// <summary>
        /// Extract the <see cref="Track"/>s from the HTML.
        /// </summary>
        /// <param name="sourceCode">Non null string.</param>
        /// <param name="clean">Non null custom cleaning object.</param>
        /// <returns>Non null <see cref="Track"/> collection.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal static List<Music> Process(string sourceCode, ICleaner clean)
        {
            // TODO: HtmlAgilityPack
            string substrint_string = "TRACKLISTA";

            sourceCode = sourceCode.Substring(sourceCode.IndexOf(substrint_string));
            sourceCode = sourceCode.Substring(0, sourceCode.IndexOf("</div></div></div>  </div>"));

            // [FIX] <a href="google.hu">Click here</a> to Click here
            sourceCode = Regex.Replace(sourceCode, @"<a\s*[^>]*><u>(.*)</u><\/a>", "$1");
            sourceCode = Regex.Replace(sourceCode, @"<a\s*[^>]*>(.*)<\/a>", "$1");
            sourceCode = Regex.Replace(sourceCode, @"<[^>]*>", "\n");
            sourceCode = Regex.Replace(sourceCode, @"[\r\n]+", "\n");

            string[] lines = sourceCode.Split(new string[] { "\n" }, StringSplitOptions.None);

            List<Music> tracklist = new List<Music>();

            for (int i = 0; i < lines.Length; i++)
            {
                string musicName = lines[i];

                if (musicName.Length < 3 ||
                    clean.IsNotArtist(musicName))
                {
                    continue;
                }

                // [FIX] Multiple spaces replace single space
                musicName = Regex.Replace(musicName, @"\s+", " ").Trim();

                musicName = musicName.Replace("MK DJ", "")
                                       .Replace("() ", "")
                                       .Replace("( ", "(")
                                       .Replace(" )", ")");

                musicName = clean.MusicPrefixes(musicName);
                musicName = clean.MusicPostfixes(musicName);

                musicName = HtmlEntity.DeEntitize(musicName);

                if (musicName.Length < 3)
                {
                    continue;
                }

                tracklist.Add(new Music(musicName));
            }

            return tracklist;
        }
    }
}
