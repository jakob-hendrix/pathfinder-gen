using System.Linq;
using System.Windows;
using PathfinderIM.Data;

namespace PathfinderItems.DesktopDataManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PathfinderItemContext _context;

        public MainWindow(PathfinderItemContext context)
        {
            InitializeComponent();
            _context = context;

            ItemGrid.ItemsSource = _context.WondrousItems.ToList();
        }
    }
}
