using NUnit.Framework;
using PoLaKoSz.MusicFM.Parsers;

namespace PoLaKoSz.MusicFM.Tests.Unit.Parsers
{
    class CleanerTests
    {
        private readonly ICleaner _clean;



        public CleanerTests()
        {
            _clean = new Cleaner();
        }



        [TestCase("MUSIC KILLERS DJ SHOW - LIVE - AT THE TURNTABLE: NEWL")]
        [TestCase("MUSIC KILLERS LIVE - AT THE TURNTABLE: NIGEL STATELY")]
        [TestCase("MUSIC KILLERS SATURTAY - HARDWELL")]
        [TestCase("MUSIC KILLERS - AT THE TURNTABLE ZOOHACKER")]
        [TestCase("MUSIC KILLERS - AT THE TURNTABLE: ANTONYO")]
        [TestCase("AT THE TURNTABLE - ANTONYO")]
        [TestCase("MUSIC PARTY LIVE MIX - DJ NARA")]
        [TestCase("ROAD SHOW LIVE MIX - NIGEL STATELY")]
        [TestCase("MUSIC KILLERS TOP 5 - NARA")]
        [TestCase("MUSIC KILLERS - TOP 20")]
        [TestCase("MK 2016 - AT THE TURNTABLE: LAUER")]
        public void IsNotArtist_Should_Be_True(string artistName)
        {
            Assert.IsTrue(_clean.IsNotArtist(artistName));
        }

        [TestCase("MUSIC KILLERS DJ SHOW - LIVE - AT THE TURNTABLE: NEWL")]
        [TestCase("MUSIC KILLERS LIVE - AT THE TURNTABLE: NIGEL STATELY")]
        [TestCase("MUSIC KILLERS SATURTAY - HARDWELL")]
        [TestCase("MUSIC KILLERS - AT THE TURNTABLE ZOOHACKER")]
        [TestCase("MUSIC KILLERS - AT THE TURNTABLE: ANTONYO")]
        [TestCase("AT THE TURNTABLE - ANTONYO")]
        [TestCase("MUSIC PARTY LIVE MIX - DJ NARA")]
        [TestCase("ROAD SHOW LIVE MIX - NIGEL STATELY")]
        [TestCase("MUSIC KILLERS TOP 5 - NARA")]
        [TestCase("MUSIC KILLERS - TOP 20")]
        [TestCase("MK 2016 - AT THE TURNTABLE: LAUER")]
        public void IsNotArtist_Should_Be_Case_Sensitive(string artistName)
        {
            Assert.IsFalse(_clean.IsNotArtist(artistName.ToLower()));
        }

        [TestCase("Progressive Pick: HALIENE - Dream In Color", "HALIENE - Dream In Color")]
        [TestCase("Future Favorite: Omar Diaz - Bassa Marea", "Omar Diaz - Bassa Marea")]
        [TestCase("Tune Of The Week: Armin van Buuren - Lifting You Higher", "Armin van Buuren - Lifting You Higher")]
        [TestCase("Service For Dreamers: Sean Tyas - Drop", "Sean Tyas - Drop")]
        [TestCase("Trending Track: Plumb - Music Rescues Me", "Plumb - Music Rescues Me")]
        [TestCase("TUNE OF THE WEEK: Shapov - Our Origin", "Shapov - Our Origin")]
        public void MusicPrefixes_Should_Clean_These(string input, string expected)
        {
            Assert.AreEqual(expected, _clean.MusicPrefixes(input));
        }


        [TestCase("PROGRESSIVE PICK: JES - Heartbeat Tonight", "JES - Heartbeat Tonight")]
        public void MusicPrefixes_Should_Be_Case_InSensitive(string input, string expected)
        {
            Assert.AreEqual(expected, _clean.MusicPrefixes(input));
        }
    }
}
