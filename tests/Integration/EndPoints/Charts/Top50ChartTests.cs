using NUnit.Framework;
using PoLaKoSz.MusicFM.EndPoints;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints
{
    class Top50ChartTests : ChartBase
    {
        private readonly Top50Chart _top50;



        public Top50ChartTests()
            : base(50)
        {
            _top50 = new Top50Chart(base.HttpClient);

            base.SetServerResponse("all");
        }



        [Test]
        public async Task Can_Parse_All_Without_Any_Formatting()
        {
            var actual = await _top50.All(new CleanerMock());

            Assert.That(actual.Count, Is.EqualTo(29), "actual.Count");
            Assert.That(actual[0].Artist, Is.EqualTo("(MK DJ) Willcox"), "actual[0].Artist");
        }

        [Test]
        public async Task Can_Parse_All_With_Formatting()
        {
            var actual = await _top50.All();

            Assert.That(actual.Count, Is.EqualTo(29), "actual.Count");
            Assert.That(actual[0].Artist, Is.EqualTo("Willcox"), "actual[0].Artist");
        }
    }
}
