using NUnit.Framework;
using PoLaKoSz.MusicFM.EndPoints;
using PoLaKoSz.MusicFM.Models;
using PoLaKoSz.MusicFM.Tests.Integration.StaticResources.MusicKillers;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.Tests.Regression.EndPoints
{
    class MusicKillerTests
    {
        private readonly MusicKiller _musicKiller;



        public MusicKillerTests()
        {
            _musicKiller = new MusicKillers(new DataAccessLayer.Web.HttpClient()).TracklistFrom;
        }



        [Test]
        public async Task Can_Scrape_Live_Old_Antonyo_Tracklist()
        {
            var actual = await _musicKiller.Antonyo();

            ShrinkScrapedTracklistToOlderTracklist(actual, Antonyo.Tracklist);

            CollectionAssert.AreEqual(Antonyo.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_ArminVanBuuren_Tracklist()
        {
            var actual = await _musicKiller.ArminVanBuuren();

            ShrinkScrapedTracklistToOlderTracklist(actual, ArminVanBuuren.Tracklist);

            CollectionAssert.AreEqual(ArminVanBuuren.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_DannyL_Tracklist()
        {
            var actual = await _musicKiller.DannyL();

            ShrinkScrapedTracklistToOlderTracklist(actual, DannyL.Tracklist);

            CollectionAssert.AreEqual(DannyL.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_DeepLison_Tracklist()
        {
            var actual = await _musicKiller.DeepLison();

            CollectionAssert.AreEqual(DeepLison.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_DjNara_Tracklist()
        {
            var actual = await _musicKiller.DjNara();

            ShrinkScrapedTracklistToOlderTracklist(actual, DjNara.Tracklist);

            CollectionAssert.AreEqual(DjNara.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_DonDiablo_Tracklist()
        {
            var actual = await _musicKiller.DonDiablo();

            ShrinkScrapedTracklistToOlderTracklist(actual, DonDiablo.Tracklist);

            CollectionAssert.AreEqual(DonDiablo.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Hardwell_Tracklist()
        {
            var actual = await _musicKiller.Hardwell();

            ShrinkScrapedTracklistToOlderTracklist(actual, Hardwell.Tracklist);

            CollectionAssert.AreEqual(Hardwell.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Jovan_Tracklist()
        {
            var actual = await _musicKiller.Jovan();

            ShrinkScrapedTracklistToOlderTracklist(actual, Jovan.Tracklist);

            CollectionAssert.AreEqual(Jovan.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Lauer_Tracklist()
        {
            var actual = await _musicKiller.Lauer();

            ShrinkScrapedTracklistToOlderTracklist(actual, Lauer.Tracklist);

            CollectionAssert.AreEqual(Lauer.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Newl_Tracklist()
        {
            var actual = await _musicKiller.Newl();

            ShrinkScrapedTracklistToOlderTracklist(actual, Newl.Tracklist);

            CollectionAssert.AreEqual(Newl.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_NigelStately_Tracklist()
        {
            var actual = await _musicKiller.NigelStately();

            ShrinkScrapedTracklistToOlderTracklist(actual, NigelStately.Tracklist);

            CollectionAssert.AreEqual(NigelStately.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_OliverHeldens_Tracklist()
        {
            var actual = await _musicKiller.OliverHeldens();

            ShrinkScrapedTracklistToOlderTracklist(actual, OliverHeldens.Tracklist);

            CollectionAssert.AreEqual(OliverHeldens.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Pixa_Tracklist()
        {
            var actual = await _musicKiller.Pixa();

            ShrinkScrapedTracklistToOlderTracklist(actual, Pixa.Tracklist);

            CollectionAssert.AreEqual(Pixa.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Tiesto_Tracklist()
        {
            var actual = await _musicKiller.Tiesto();

            ShrinkScrapedTracklistToOlderTracklist(actual, Tiesto.Tracklist);

            CollectionAssert.AreEqual(Tiesto.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Willcox_Tracklist()
        {
            var actual = await _musicKiller.Willcox();

            ShrinkScrapedTracklistToOlderTracklist(actual, Willcox.Tracklist);

            CollectionAssert.AreEqual(Willcox.Tracklist, actual);
        }

        [Test]
        public async Task Can_Scrape_Live_Old_Yamina_Tracklist()
        {
            var actual = await _musicKiller.Yamina();

            ShrinkScrapedTracklistToOlderTracklist(actual, Yamina.Tracklist);

            CollectionAssert.AreEqual(Yamina.Tracklist, actual);
        }

        [Test]
        public void Can_Scrape_Live_Old_Zoohacker_Tracklist()
        {
            var ex = Assert.ThrowsAsync<HttpRequestException>(async () => await _musicKiller.Zoohacker(),
                "Yeehy, the devs at Musicfm.hu finally fixed the HTTP 403 error! Time to make Integration test Zoohacker!");

            Assert.AreEqual("HTTP Forbidden returned while loading http://musicfm.hu/musorvezeto/zoohacker", ex.Message, "ex.Message");
        }
        

        private void ShrinkScrapedTracklistToOlderTracklist(List<Music> actualTracklist, List<Music> oldTracklist)
        {
            actualTracklist.RemoveRange(0, (actualTracklist.Count - oldTracklist.Count));
        }
    }
}
