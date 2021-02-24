using TutorialPoint.Nav.Wpf.Commands;

namespace TutorialPoint.Nav.Wpf.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private BindableBase _currentViewModel;
        private CustomerViewModel _customerViewModel = new CustomerViewModel();
        private OrderViewModel _orderViewModel = new OrderViewModel();

        public MainWindowViewModel()
        {
            NavCommand = new BaseCommand<string>(OnNav);
        }

        public BaseCommand<string> NavCommand { get; }

        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        /// <summary>
        /// Takes a string destination and returns the CurrentViewModel property
        /// </summary>
        /// <param name="destination"></param>
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "orders":
                    CurrentViewModel = _orderViewModel;
                    break;
                case "customers":
                default:
                    CurrentViewModel = _customerViewModel;
                    break;
            }
        }
    }
}
