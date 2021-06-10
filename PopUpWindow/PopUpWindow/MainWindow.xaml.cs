using Prism.Services.Dialogs;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace PopUpWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            if (viewModel.currentSession.IsSessionOpen==true)
                UnfinishedSession();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.currentSession.IsSessionOpen = false;
            
            Debug.Write($"{viewModel.currentSession.TextContent}\n " +
                $"{viewModel.currentSession.IsSessionOpen}");
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.currentSession.TextContent = textBox1.Text;
            viewModel.currentSession.IsSessionOpen = true;
        }
        void UnfinishedSession()
        {
            const string message = "Masz niedokończoną sesję, czy chcesz kontynuuować?";
            MessageBoxResult result = MessageBox.Show(message,"?", MessageBoxButton.YesNo);
            
            if(result == MessageBoxResult.Yes)
            {
                viewModel.currentSession.IsSessionOpen = true;
                WriteInto();
            }
            else
            {
                viewModel.currentSession.IsSessionOpen = false;
                textBox1.Clear();
            }
            
        }
        void WriteInto()
        {
            textBox1.Text = viewModel.currentSession.TextContent;
        }
    }
}
