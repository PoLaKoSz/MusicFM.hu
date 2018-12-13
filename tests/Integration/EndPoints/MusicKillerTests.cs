using NUnit.Framework;
using PoLaKoSz.MusicFM.EndPoints;
using PoLaKoSz.MusicFM.Models;
using PoLaKoSz.MusicFM.Tests.Integration.StaticResources.MusicKillers;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints
{
    class MusicKillerTests : TestClassBase
    {
        private readonly MusicKiller _musicKiller;


        /*
               function removeElementsByClass(className){
                    var elements = document.getElementsByClassName(className);
                    while(elements.length > 0){
                        elements[0].parentNode.removeChild(elements[0]);
                    }
                }

                jQuery("#header").remove();
                jQuery("#navigation").remove();
                jQuery("#partners").remove();
                jQuery("#block-menu-menu-footer-top").remove();
                jQuery("#block-block-2").remove();

                removeElementsByClass("panel-panel panel-col-last");
                removeElementsByClass("region region-bottom");
                removeElementsByClass("panel-pane pane-panel-musor-image");




                REPLACE		\n+					\n
                REPLACE		\n \n				\n
                REPLACE		\n[ ]+				\n
                REPLACE		[ ]+\n				\n
                REPLACE		\n+					\n
                REPLACE 	[ ]+				(space)
                REPLACE		\([ ]+				(
                REPLACE		[ ]+\)				)
                REPLACE		.*TRACKLISTA.*\n	(semmi)
                REPLACE		.*TRACKLSITA.*\n	(semmi)
                REPLACE		ID - ID\n			(semmi)

                REPLACE		\n					"),\n
                REPLACE		^					\t\t\t\tnew Music("
        */


        public MusicKillerTests()
            : base("MusicKillers")
        {
            _musicKiller = new MusicKillers(base.HttpClient).TracklistFrom;
        }



        [Test]
        public async Task Can_Parse_Antonyo()
        {
            base.SetServerResponse("antonyo");


            var actual = await _musicKiller.Antonyo();


            CollectionAssert.AreEqual(Antonyo.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Armin_Van_Buuren()
        {
            base.SetServerResponse("armin-van-buuren");



            var actual = await _musicKiller.ArminVanBuuren();



            CollectionAssert.AreEqual(ArminVanBuuren.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_DannyL()
        {
            base.SetServerResponse("dannyl");


            var actual = await _musicKiller.DannyL();


            CollectionAssert.AreEqual(DannyL.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_DeepLison()
        {
            base.SetServerResponse("deep-lison");


            var actual = await _musicKiller.DeepLison();


            CollectionAssert.AreEqual(DeepLison.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_DjNara()
        {
            base.SetServerResponse("dj-nara");


            var actual = await _musicKiller.DjNara();


            CollectionAssert.AreEqual(DjNara.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_DonDiablo()
        {
            base.SetServerResponse("don-diablo");


            var actual = await _musicKiller.DonDiablo();


            CollectionAssert.AreEqual(DonDiablo.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Hardwell()
        {
            base.SetServerResponse("hardwell");


            var actual = await _musicKiller.Hardwell();


            CollectionAssert.AreEqual(Hardwell.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Jovan()
        {
            base.SetServerResponse("jovan");


            var actual = await _musicKiller.Jovan();


            CollectionAssert.AreEqual(Jovan.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Lauer()
        {
            base.SetServerResponse("lauer");


            var actual = await _musicKiller.Lauer();


            CollectionAssert.AreEqual(Lauer.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Newl()
        {
            base.SetServerResponse("newl");


            var actual = await _musicKiller.Newl();


            CollectionAssert.AreEqual(Newl.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_NigelStately()
        {
            base.SetServerResponse("nigel-stately");


            var actual = await _musicKiller.NigelStately();


            CollectionAssert.AreEqual(NigelStately.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_OliverHeldens()
        {
            base.SetServerResponse("oliver-heldens");


            var actual = await _musicKiller.OliverHeldens();


            CollectionAssert.AreEqual(OliverHeldens.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Pixa()
        {
            base.SetServerResponse("pixa");


            var actual = await _musicKiller.Pixa();


            CollectionAssert.AreEqual(Pixa.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Tiesto()
        {
            base.SetServerResponse("tiesto");


            var actual = await _musicKiller.Tiesto();


            CollectionAssert.AreEqual(Tiesto.Tracklist, actual);

            Assert.AreEqual(
                new Music("Tim Berg – Bromance (Avicii Arena Mix) [Tiësto’s Classic]"),
                actual[1657],
                "This should be fixed automatically when the page parsed with HtmlAgilityPack!\n\n\n");
        }

        [Test]
        public async Task Can_Parse_Willcox()
        {
            base.SetServerResponse("willcox");


            var actual = await _musicKiller.Willcox();


            CollectionAssert.AreEqual(Willcox.Tracklist, actual);
        }

        [Test]
        public async Task Can_Parse_Yamina()
        {
            base.SetServerResponse("yamina");


            var actual = await _musicKiller.Yamina();


            CollectionAssert.AreEqual(Yamina.Tracklist, actual);
        }

        [Test]
        public void Can_Parse_Zoohacker()
        {
            Assert.Warn("DJ page can not be accessed, so nothing to compare with.");
        }
    }
}
