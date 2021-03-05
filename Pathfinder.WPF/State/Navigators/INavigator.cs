using System.Windows.Input;
using Pathfinder.WPF.ViewModels;

namespace Pathfinder.WPF.State.Navigators
{
    public interface INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
