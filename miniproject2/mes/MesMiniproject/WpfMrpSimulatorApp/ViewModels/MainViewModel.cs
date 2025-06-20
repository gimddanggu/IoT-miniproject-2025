using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using WpfMrpSimulatorApp.Helpers;
using WpfMrpSimulatorApp.Views;

namespace WpfMrpSimulatorApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        // 다이얼로그 코디네이터 변수 선언
        private readonly IDialogCoordinator dialogCoordinator;

        private string _greeting;
        private UserControl _currentView;

        public MainViewModel(IDialogCoordinator coordinator)
        {
            this.dialogCoordinator = coordinator;
            Greeting = "MRP 공정관리!";
        }
        public string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);   
        }

        public UserControl CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        [RelayCommand]
        public async Task AppExit()
        {
            //var result = MessageBox.Show("종료할 거?", "종료확인", MessageBoxButton.YesNo, MessageBoxImage.Question);
            var result = await this.dialogCoordinator.ShowMessageAsync(this, "종료확인", "종료할것이니?", MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Affirmative)
            {
                Application.Current.Shutdown();
            }
            else
            {
                return;
            }
        }

        [RelayCommand]
        public void AppSetting()
        {
            //var result = MessageBox.Show("종료할 거?", "종료확인", MessageBoxButton.YesNo, MessageBoxImage.Question);
            var viewModel = new SettingViewModel();
            var view = new SettingView
            {
                DataContext = viewModel,
            };

            CurrentView = view;
        }
    }
}
