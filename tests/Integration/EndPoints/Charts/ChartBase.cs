using System;

namespace PoLaKoSz.MusicFM.Tests.Integration.EndPoints
{
    abstract class ChartBase : TestClassBase
    {
        public ChartBase(int type)
            : base($"Charts/{type}/") { }
    }
}
