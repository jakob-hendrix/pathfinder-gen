using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
