using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Timers;
using DevExpress.Xpf.Charts;

namespace CPS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            Class1.frame = frameMain;
            Class1.frame.Navigate(new Page1());
            //MaxWidth = ActualWidth;
            //MaxHeight = ActualHeight;
            //MinWidth = ActualWidth;
            //MinHeight = ActualHeight;
            // this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer.Interval = TimeSpan.FromSeconds(1.5);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var hello = new List<string> { "Добро пожаловать", "Здесь Вы найдете любые компоненты на ваше Авто", "Ваши конфиденциальные данные всегда в безопасности.", "Пишите нам на почту, ответим всегда! :)" };
            Random random = new Random();
            int index = random.Next(hello.Count);
            var hellous = hello[index];
            this.Title = hellous;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //{
            //    this.DragMove();
            //}
        }
    }
}
