using System.Collections.Generic;

namespace PoLaKoSz.MusicFM.Models
{
    /// <summary>
    /// Used instead of the <see cref="Track"/> when the artist and the
    /// song title is not seperated in a recognizable format.
    /// </summary>
    public class Music
    {
        /// <summary>
        /// Full name of the song (artist(s) name + song title).
        /// </summary>
        public string Name { get; }



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="name">Non null string.</param>
        public Music(string name)
        {
            Name = name;
        }



#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            var anotoherMusic = (Music)obj;

            if (!Name.Equals(anotoherMusic.Name))
                return false;

            return true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override string ToString()
        {
            // Leave it like this for Unit tests!!
            return Name;
        }
    }
}
