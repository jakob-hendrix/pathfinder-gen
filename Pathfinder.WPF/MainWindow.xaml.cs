namespace Pathfinder.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(object dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
        }
    }
}
