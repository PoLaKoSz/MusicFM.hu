using System.Collections.Generic;
using PoLaKoSz.MusicFM.Models;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints.HomePage.TimeLine
{
    class EmptyTimeline : TimeLineBase
    {
        private static readonly List<Track> _raw = new List<Track>();
        private static readonly List<Track> _cleaned = new List<Track>();



        public EmptyTimeline()
            : base(_raw, _cleaned)
        {
            base.SetResponseFromServer(@"HomePage\timeline.json");
        }
    }
}
