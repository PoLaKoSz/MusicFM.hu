﻿using System;

namespace PoLaKoSz.MusicFM.Models
{
    /// <summary>
    /// Used when the artist(s) name and the song title seperated in
    /// a recognizable format. When it's note, use the <see cref="Music"/> class.
    /// </summary>
    public class Track
    {
        /// <summary>
        /// The artist(s) name of the track.
        /// </summary>
        public string Artist { get; }

        /// <summary>
        /// Name of the track.
        /// </summary>
        public string Name { get; }



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="artist">Non null string.</param>
        /// <param name="name">Non null string.</param>
        public Track(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }


        public override string ToString()
        {
            return string.Format("{0} - {1}", Artist, Name);
        }

        public override bool Equals(object obj)
        {
            var another = (Track)obj;

            if (!Artist.Equals(another.Artist))
                return false;

            if (!Name.Equals(another.Name))
                return false;

            return true;
        }
    }
}
