using PoLaKoSz.MusicFM;
using PoLaKoSz.MusicFM.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicFM = new MusicFM();

            var MKdjTracklist = musicFM.MusicKillers.TracklistFrom.Antonyo().GetAwaiter().GetResult();
            DisplayTracklist(MKdjTracklist, "MK DJ Antonyo");


            var timeLine = musicFM.HomePage.Timeline().GetAwaiter().GetResult();
            DisplayTracklist(timeLine, "Timeline");


            var top20Tracks = musicFM.Charts.Top20.All().GetAwaiter().GetResult();
            DisplayTracklist(top20Tracks, "TOP 20");


            var top50Tracks = musicFM.Charts.Top50.All().GetAwaiter().GetResult();
            DisplayTracklist(top50Tracks, "TOP 50");

            Console.Read();
        }

        private static void DisplayTracklist(List<Track> tracklist, string name)
        {
            Console.WriteLine(name);

            for (int i = 0; i < tracklist.Count; i++)
            {
                var track = tracklist[i];

                Console.WriteLine($"\t#{i,3}\t{track.Artist} - {track.Name}");
            }

            Console.WriteLine("\n");
        }

        private static void DisplayTracklist(List<Music> tracklist, string name)
        {
            Console.WriteLine(name);

            for (int i = 0; i < tracklist.Count; i++)
            {
                var track = tracklist[i];

                Console.WriteLine($"\t#{i,3}\t{track.Name}");
            }

            Console.WriteLine("\n");
        }
    }
}
