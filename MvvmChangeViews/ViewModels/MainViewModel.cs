using System.Runtime.CompilerServices;
using System.Windows.Input;
using MvvmChangeViews.Commands;

namespace MvvmChangeViews.ViewModels
{
    /// <summary>
    /// View model that contains the general application. Controls navigation.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel = new HomeViewModel();

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

        public BaseViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set => _selectedViewModel = value;
        }

        public ICommand UpdateViewCommand { get; set; }
    }
}
