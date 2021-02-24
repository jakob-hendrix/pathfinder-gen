using System.Collections.ObjectModel;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvxTutorial.Core.Models;

namespace MvxTutorial.Core.ViewModels
{
    // All MvvmCross VMs inherit from MvxViewModel
    public class GuestBookViewModel : MvxViewModel
    {
        private ObservableCollection<PersonModel> _people = new ObservableCollection<PersonModel>();
        private string _firstName;
        private string _lastName;

        public GuestBookViewModel()
        {
            AddGuestCommand = new MvxCommand(AddGuest);
        }

        public ObservableCollection<PersonModel> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                SetProperty(ref _firstName, value);
                RaisePropertyChanged(() => FullName);
                RaisePropertyChanged(() => CanAddGuest);
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                SetProperty(ref _lastName, value);
                RaisePropertyChanged(() => FullName);
                RaisePropertyChanged(() => CanAddGuest);
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public bool CanAddGuest => FirstName?.Length > 0 && LastName?.Length > 0;

        public void AddGuest()
        {
            PersonModel person = new PersonModel
            {
                FirstName = FirstName,
                LastName = LastName
            };

            FirstName = string.Empty;
            LastName = string.Empty;

            People.Add(person);
        }

        // This command will call the AddGuest method
        public IMvxCommand AddGuestCommand { get; set; }
    }
}
