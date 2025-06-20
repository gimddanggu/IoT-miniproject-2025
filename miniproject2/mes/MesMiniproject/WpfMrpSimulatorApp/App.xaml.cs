using System.Configuration;
using System.Data;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using WpfMrpSimulatorApp.Helpers;
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
            Common.DIALOGCOORDINATOR = DialogCoordinator.Instance;

            var viewModel = new MainViewModel(Common.DIALOGCOORDINATOR);
            var view = new MainView
            {
                DataContext = viewModel,
            };
            view.ShowDialog();
        }
    }

}
