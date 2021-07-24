using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace SampleMvvmCrossIosApplciation.MvvmCross
{
    public class HelloViewModel : MvxViewModel
    {
        public HelloViewModel()
        {
        }

        public override void Prepare()
        {
            // This is the first method to be called after construction
        }

        public override Task Initialize()
        {
            // Async initialization, YEY!

            return base.Initialize();
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }
    }
}
