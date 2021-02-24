using System;
using System.Windows;

namespace PathfinderSheetDesktopUI
{
    /// <summary>
    /// Interaction logic for InputPrompt.xaml
    /// </summary>
    public partial class InputPrompt : Window
    {
        public InputPrompt(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            Question.Content = question;
            Answer.Text = defaultAnswer;
        }

        private void Ok_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Answer.SelectAll();
            Answer.Focus();
        }

        public string PromptAnswer
        {
            // Make answer edits here
            get => Answer.Text;
        }
    }
}
