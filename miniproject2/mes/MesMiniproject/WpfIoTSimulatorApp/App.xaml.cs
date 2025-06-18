using System.Configuration;
using System.Data;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using WpfIoTSimulatorApp.ViewModels;
using WpfIoTSimulatorApp.Views;

namespace WpfIoTSimulatorApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var viewModel = new MainViewModel();
            var view = new MainView
            {
                DataContext = viewModel,
            };

            viewModel.StartHmiRequested += view.StartHmiAni;
            viewModel.StartSensorCheckRequested += view.StartSensorCheck; // VM에서 View에 있는 이벤트를 호출

            view.ShowDialog();
        }
    }
}
