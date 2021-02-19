using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace PathfinderSheetDesktopUI.Views
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

        private void BtnSaveFile_OnClick(object sender, RoutedEventArgs e)
        {
            var saveFileDialogue = new SaveFileDialog
            {
                // <-- TODO: set default naming convention {name}_{class1}{##}_{class2}##.pfs
                FileName = "pathfinder_character.pfs",
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Pathfinder Sheets (*.pfs)|*.pfs"
            };
            if (saveFileDialogue.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialogue.FileName, $"{DateTime.Now}: test");
            }
        }

        private void EnterRaceButton_OnClick(object sender, RoutedEventArgs e)
        {
            var racePrompt = new InputPrompt("Please enter the character's race:");
            if (racePrompt.ShowDialog() == true)
            {
                Race.Text = racePrompt.PromptAnswer;
            }
        }
    }
}
