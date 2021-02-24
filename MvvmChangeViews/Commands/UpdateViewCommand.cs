using System;
using System.Windows.Input;
using MvvmChangeViews.ViewModels;

namespace MvvmChangeViews.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel _viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Home")
            {
                _viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "Account")
            {
                _viewModel.SelectedViewModel = new AccountViewModel();
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
