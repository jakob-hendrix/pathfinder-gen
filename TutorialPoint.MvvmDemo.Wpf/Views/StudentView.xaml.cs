using System.Windows.Controls;
using TutorialPoint.MvvmDemo.Wpf.ViewModels;

namespace TutorialPoint.MvvmDemo.Wpf.Views
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }
    }
}
