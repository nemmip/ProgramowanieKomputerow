using System.Diagnostics;
using System.Windows;

namespace PopUpWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Exit(object sender, ExitEventArgs e)
        {
            ViewModel.SaveClass();
            Debug.Write("Zapisano zmiany...");
        }
    }
}
