using System.Windows.Input;
using Pathfinder.WPF.Commands;
using Pathfinder.WPF.Models;
using Pathfinder.WPF.ViewModels;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.State
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;

        public Navigator(IPathfinderViewModelAbstractFactory viewModelFactory)
        {
            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(this, viewModelFactory);
        }

        // Set the current view and let the UI know
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand UpdateCurrentViewModelCommand { get; }
    }
}
