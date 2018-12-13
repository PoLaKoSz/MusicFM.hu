using NUnit.Framework;
using PoLaKoSz.MusicFM.EndPoints;
using System.Threading.Tasks;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints
{
    class Top20ChartTests : ChartBase
    {
        private readonly Top20Chart _top20;



        public Top20ChartTests()
            : base(20)
        {
            _top20 = new Top20Chart(base.HttpClient);

            base.SetServerResponse("all");
        }



        [Test]
        public async Task Can_Parse_All_Without_Any_Formatting()
        {
            var actual = await _top20.All(new CleanerMock());

            Assert.That(actual.Count, Is.EqualTo(20), "actual.Count");
            Assert.That(actual[13].Artist, Is.EqualTo("(MK DJ) Antonyo"), "actual[13].Artist");
        }

        [Test]
        public async Task Can_Parse_All_With_Formatting()
        {
            var actual = await _top20.All();

            Assert.That(actual.Count, Is.EqualTo(20), "actual.Count");
            Assert.That(actual[13].Artist, Is.EqualTo("Antonyo"), "actual[13].Artist");
        }
    }
}
