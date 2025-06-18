using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace WpfIoTSimulatorApp.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : MetroWindow
    {
        //private readonly MainView _viewModel;
        public MainView()
        {
            InitializeComponent();
        }

        // 뷰상에 있는 이벤트핸들러를 전부 제거
        // WPF상의 객체 애니메이션 추가. 애니메이션은 디자이너역할(view)
        //Timer timer = new Timer();
        Stopwatch sw = new Stopwatch();


        public void StartHmiAni()
        {

            // 기어애니메이션
            DoubleAnimation ga = new DoubleAnimation
            {
                From = 0,
                To = 360, // 360도 회전
                Duration = TimeSpan.FromSeconds(2),
            };

            RotateTransform rt = new RotateTransform();
            GearStart.RenderTransform = rt;
            GearStart.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            GearEnd.RenderTransform = rt;
            GearEnd.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);


            rt.BeginAnimation(RotateTransform.AngleProperty, ga);

            // 제품애니메이션
            DoubleAnimation pa = new DoubleAnimation 
            {
                From = 100,
                To = 437, // X축: 센서아래 위치
                Duration = TimeSpan.FromSeconds(5),  // 계획 로드타임 (Schedules의 LoadTime 값이 들어가야 함)
            }; // 이런 초기화가 좀 더 최신 코딩방식
            // 아래는 구식 코딩방식
            //pa.From = 100;
            //pa.To = 437; // X축: 센서아래 위치
            //pa.Duration = TimeSpan.FromSeconds(5);  // 계획 로드타임 (Schedules의 LoadTime 값이 들어가야 함)

            Product.BeginAnimation(Canvas.LeftProperty, pa);
        }

        public void StartSensorCheck()
        {
            // 센서 애니메이션
            DoubleAnimation sa = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true
            };

            SortingSensor.BeginAnimation(OpacityProperty, sa);

        }
    }
}
