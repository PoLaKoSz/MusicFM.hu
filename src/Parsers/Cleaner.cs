using System;
using System.Text.RegularExpressions;

namespace PoLaKoSz.MusicFM.Parsers
{
    /// <summary>
    /// Built-in implementation to clean the source code from the junk.
    /// </summary>
    public class Cleaner : ICleaner
    {
        /// <summary>
        /// Removes the token from the given image URL's end.
        /// </summary>
        /// <param name="imageURL">Non null path to the image.</param>
        /// <returns>Cleaned image URL.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string RemoveImageToken(Uri imageURL)
        {
            string URL = imageURL.ToString();

            try
            {
                int length = URL.IndexOf("?itok");

                URL = URL.Substring(0, length);
            }
            catch { }

            return URL;
        }

        /// <summary>
        /// Determinate that the given artist is a person
        /// or a show (Music Killers, Road Show, etc.).
        /// </summary>
        /// <param name="artist">Non null artist name.</param>
        /// <returns>True if the parameter is a show.</returns>
        public bool IsNotArtist(string artist)
        {
            string pattern = @"(MUSIC KILLERS)|" +
                              "(MADE IN HUNGARY LIVE MIX)|" +
                              @"(^\[Tiësto’s Exclusive\]$)|" +
                              @"(^\[Mashup Of The Week\]$)|" +
                              @"(^\[Tiësto’s Classic\]$)|" +
                              "(ROAD SHOW LIVE MIX)|" +
                              "(AT THE TURNTABLE)|" +
                              "(MUSIC PARTY)|" +
                              "(TRACKLISTA)|" +
                              "(TRACKILSTA)|" +
                              "(TRACKLSITA)|" +
                              "(TRACKISTA)|" +
                              "(TRACKLSTA)|" +
                              "(TRACKLITA)|" +
                              "(Tracklista)|" +
                              "(ACKLISTA)|" +
                              "(ID - ID)";

            Match match = Regex.Match(artist, pattern);

            return match.Success;
        }

        /// <summary>
        /// Removes the (MK DJ) prefix from the string.
        /// </summary>
        /// <param name="name">Non null string.</param>
        /// <returns>Non null string.</returns>
        public string ArtistName(string name)
        {
            string pattern = @"(\B\(MK DJ\) )|(MK DJ )|(\B\(MK\) )";

            return Regex.Replace(name, pattern, "");
        }

        /// <summary>
        /// Removes characters from the start of the parameter string.
        /// </summary>
        /// <param name="musicName">Non null string.</param>
        /// <returns>Non null string.</returns>
        public string MusicPrefixes(string musicName)
        {
            string pattern = @"(Progressive Pick: )|" +
                              "(PROGRESSIVE PICK )|" +
                              "(Future Favorite: )|" +
                              "(Tune Of The Week: )|" +
                              "(Service For Dreamers: )|" +
                              "(Trending Track: )|" +
                              "(TUNE OF THE WEEK: )";

            return Regex.Replace(musicName, pattern, "", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Removes characters from the end of the parameter string.
        /// </summary>
        /// <param name="musicName">Non null string.</param>
        /// <returns>Non null string.</returns>
        public string MusicPostfixes(string musicName)
        {
            string pattern = "(Hot From the Studio)|" +
                            @"( \[Hot From the Studio\])|" +
                             "(Request of the Week)|" +
                            @"( \[Request of the Week\])|" +
                            @"( \[Tiësto’s Exclusive\])";

            return Regex.Replace(musicName, pattern, "", RegexOptions.IgnoreCase);
        }
    }
}
