using System.Configuration;
using System.Data;
using System.Windows;
using WpfMrpSimulatorApp.ViewModels;
using WpfMrpSimulatorApp.Views;

namespace WpfMrpSimulatorApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_StartUp(object sender, StartupEventArgs e)
        {
            var viewModel = new MainViewModel();
            var view = new MainView
            {
                DataContext = viewModel,
            };
            view.ShowDialog();
        }
    }

}
