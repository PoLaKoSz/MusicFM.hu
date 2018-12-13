using System;

namespace PoLaKoSz.MusicFM.Parsers
{
    /// <summary>
    /// Parsing logic how the junk be removed from the source code.
    /// </summary>
    public interface ICleaner
    {
        /// <summary>
        /// Removes the token from the given image URL's end.
        /// </summary>
        /// <param name="imageURL">Non null path to the image.</param>
        /// <returns>Cleaned image URL.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        string RemoveImageToken(Uri imageURL);

        /// <summary>
        /// Determinate that the given artist is a person
        /// or a show (Music Killers, Road Show, etc.).
        /// </summary>
        /// <param name="musicName">Non null string.</param>
        /// <returns>True if the parameter is a show.</returns>
        bool IsNotArtist(string musicName);

        /// <summary>
        /// Removes the (MK DJ) prefix from the string.
        /// </summary>
        /// <param name="name">Non null string.</param>
        /// <returns>Non null string.</returns>
        string ArtistName(string name);

        /// <summary>
        /// Removes characters from the start of the parameter string.
        /// </summary>
        /// <param name="musicName">Non null string.</param>
        /// <returns>Non null string.</returns>
        string MusicPrefixes(string musicName);

        /// <summary>
        /// Removes characters from the end of the parameter string.
        /// </summary>
        /// <param name="musicName">Non null string.</param>
        /// <returns>Non null string.</returns>
        string MusicPostfixes(string musicName);
    }
}
