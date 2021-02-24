using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MvxTutorial.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            // Get startup from Core.App.cs
            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }
    }
}
