using Caliburn.Micro;

namespace CaliburnWpf.Ui.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
    }
}
