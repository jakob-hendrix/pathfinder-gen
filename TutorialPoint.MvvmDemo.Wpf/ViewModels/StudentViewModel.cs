using System.Collections.ObjectModel;
using TutorialPoint.MvvmDemo.Wpf.Commands;
using TutorialPoint.MvvmDemo.Wpf.Models;

namespace TutorialPoint.MvvmDemo.Wpf.ViewModels
{
    public class StudentViewModel
    {
        private Student _selectedStudent;
        public ObservableCollection<Student> Students { get; set; }

        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new CustomCommand(OnDelete, CanDelete);
        }

        public CustomCommand DeleteCommand { get; set; }

        public Student SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        private bool CanDelete() => SelectedStudent != null;

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        public void LoadStudents()
        {
            Students = new ObservableCollection<Student>()
            {
                new Student() {FirstName = "Tifa", LastName = "Lockhart"},
                new Student() {FirstName = "Cloud", LastName = "Strife"},
                new Student() {FirstName = "Rufus", LastName = "Shinra"}
            };
        }
    }
}
