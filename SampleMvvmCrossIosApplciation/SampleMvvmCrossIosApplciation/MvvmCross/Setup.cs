using System;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Ios.Core;

namespace SampleMvvmCrossIosApplciation.MvvmCross
{
    public class Setup : MvxIosSetup<App>
    {
        public Setup()
        {

        }

        protected override ILoggerFactory CreateLogFactory()
        {
            return null;
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            return null;
        }
    }
}
