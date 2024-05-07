using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace PathfinderSheetDesktopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Other checks to verify if the app can be closed?
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Other code to cleanup gracefully?
            Application.Current.Shutdown();
        }

        private void ClearLog_OnClick(object sender, RoutedEventArgs e)
        {
            LogOutput.Text = String.Empty;
        }

        private void LogValues_OnClick(object sender, RoutedEventArgs e)
        {
            LogOutput.Text += $"{DateTime.Now} - Name: {txtName}, Classes: {txtClass}{Environment.NewLine}";
        }

        private void BtnOpenFile_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Pathfinder Sheets (*.pfs)|*.pfs|All Files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string fileContents = File.ReadAllText(openFileDialog.FileName);
                MessageBox.Show(fileContents);
            }
        }
    }
}
