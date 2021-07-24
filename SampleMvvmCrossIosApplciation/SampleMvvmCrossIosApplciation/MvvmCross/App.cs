using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace SampleMvvmCrossIosApplciation.MvvmCross
{
    public class App : MvxApplication
    {

        public App()
        {
        }

        public override void Initialize()
        {
            //CreatableTypes()
            //   .EndingWith("Service")
            //   .AsInterfaces()
            //   .RegisterAsLazySingleton();

            RegisterAppStart<HelloViewModel>();
        }
    }
}
