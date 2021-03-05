using System;
using System.Windows.Input;
using Pathfinder.WPF.State;
using Pathfinder.WPF.State.Navigators;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        private readonly INavigator _navigator;
        private readonly IPathfinderViewModelAbstractFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(Navigator navigator, IPathfinderViewModelAbstractFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            // TODO: any time when we should not be able to change the view?
            return true;
        }

        /// <summary>
        /// Create a ViewModel of the requested ViewType type
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (parameter is ViewType viewType)
            {
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }

            // TODO: throw an Exception here?
        }

        public event EventHandler CanExecuteChanged;
    }
}
