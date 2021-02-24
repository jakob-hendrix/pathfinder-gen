using MvvmCross.ViewModels;
using MvxTutorial.Core.ViewModels;

namespace MvxTutorial.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            // When you initialize, start here
            RegisterAppStart<GuestBookViewModel>();
        }
    }
}
