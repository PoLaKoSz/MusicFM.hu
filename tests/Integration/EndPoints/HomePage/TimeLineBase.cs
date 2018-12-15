using NUnit.Framework;
using PoLaKoSz.MusicFM.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints.HomePage
{
    abstract class TimeLineBase : TestClassBase
    {
        private readonly PoLaKoSz.MusicFM.EndPoints.HomePage _homePage;
        private readonly List<Track> _raw;
        private readonly List<Track> _cleaned;



        public TimeLineBase(List<Track> raw, List<Track> cleaned)
        {
            _homePage = new PoLaKoSz.MusicFM.EndPoints.HomePage(base.HttpClient);
            _raw = raw;
            _cleaned = cleaned;
        }



        [Test]
        public async Task Check_Cleaned_Tracklist_Count()
        {
            var actual = await _homePage.Timeline();

            Assert.That(actual.Count, Is.EqualTo(_cleaned.Count));
        }

        [Test]
        public async Task Check_Raw_Tracklist_Count()
        {
            var actual = await _homePage.Timeline(new CleanerMock());

            Assert.That(actual.Count, Is.EqualTo(_raw.Count));
        }

        [Test]
        public async Task Can_Parse_Timeline_Without_Any_Formatting()
        {
            var actual = await _homePage.Timeline(new CleanerMock());

            CollectionAssert.AreEqual(_raw, actual);
        }

        [Test]
        public async Task Can_Parse_Timeline_With_Formatting()
        {
            var actual = await _homePage.Timeline();

            CollectionAssert.AreEqual(_cleaned, actual);
        }
    }
}
