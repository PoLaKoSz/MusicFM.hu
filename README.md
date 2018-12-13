# MusicFM.hu

MusicFM.hu is the one of the most popular radio station in Hungary. This is a .NET Standard 2.0 library to can access the Timeline,
every MusicKIller DJ's tracklist and the two chart (TOP 20 and TOP 50).

### Install
via [NuGet](https://www.nuget.org/packages/MusicFM.hu/)
````
PM > Install-Package MusicFM.hu
````

### Quick start

That's all You need and can use with this library. Copied from the sample project:

```` c#
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

````
