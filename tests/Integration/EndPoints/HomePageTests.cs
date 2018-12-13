using NUnit.Framework;
using PoLaKoSz.MusicFM.EndPoints;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints
{
    class HomePageTests : TestClassBase
    {
        private readonly HomePage _homePage;



        public HomePageTests()
        {
            _homePage = new HomePage(base.HttpClient);

            base.SetServerResponse("timeline");
        }



        [Test]
        public async Task Can_Parse_Timeline_Without_Any_Formatting()
        {
            var actual = await _homePage.Timeline(new CleanerMock());

            Assert.That(actual.Count, Is.EqualTo(85), "actual.Count");
            Assert.That(actual[0].Artist, Is.EqualTo("MUSIC KILLERS LIVE"), "actual[0].Artist");
            Assert.That(actual[1].Artist, Is.EqualTo("AT THE TURNTABLE"), "actual[1].Artist");
        }

        [Test]
        public async Task Can_Parse_Timeline_With_Formatting()
        {
            var actual = await _homePage.Timeline();

            Assert.That(actual.Count, Is.EqualTo(83), "actual.Count");
            Assert.That(actual[0].Artist, Is.EqualTo("David Guetta Ft. Nicky Minaj & Jason Derulo"), "actual[0].Artist");
            Assert.That(actual[0].Name, Is.EqualTo("Goodbye"), "actual[0].Name");
        }
    }
}
