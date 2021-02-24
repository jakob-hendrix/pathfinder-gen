using System.Windows;
using Caliburn.Micro;
using CaliburnWpf.Ui.ViewModels;

namespace CaliburnWpf.Ui
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
