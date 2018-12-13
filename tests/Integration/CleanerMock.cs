using PoLaKoSz.MusicFM.Parsers;
using System;

namespace PoLaKoSz.MusicFM.Tests.Integration
{
    internal class CleanerMock : ICleaner
    {
        /// <summary>
        /// Keep the parameter untouched.
        /// </summary>
        public string ArtistName(string name)
        {
            return name;
        }

        /// <summary>
        /// Never remove any item.
        /// </summary>
        public bool IsNotArtist(string musicName)
        {
            return false;
        }

        /// <summary>
        /// Keep the <see cref="Uri"/> untouched.
        /// </summary>
        public string RemoveImageToken(Uri imageURL)
        {
            return imageURL.ToString();
        }

        public string MusicPrefixes(string musicName)
        {
            return musicName;
        }

        public string MusicPostfixes(string musicName)
        {
            return musicName;
        }
    }
}
