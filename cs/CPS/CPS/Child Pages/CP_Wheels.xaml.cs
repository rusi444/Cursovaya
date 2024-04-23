using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace CPS.Child_Pages
{
    /// <summary>
    /// Логика взаимодействия для CP_Wheels.xaml
    /// </summary>
    public partial class CP_Wheels : Page
    {
        DispatcherTimer _timer = new DispatcherTimer();

        public CP_Wheels()
        {
            InitializeComponent();
            MinHeight = 700;
            MinWidth = 600;
            DataContext = new Class2();
            gobackbtn.Content = "<<";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _timer.Interval = TimeSpan.FromSeconds(0.1);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Диски
            var CountWheels = new user16Entities1().product.Where(
                x => x.id == 2 ||
                x.id == 3 ||
                x.id == 5 ||
                x.id == 6 ||
                x.id == 8).Sum(x => x.quantity);

            GeneralCountTxb.Text = Convert.ToString(CountWheels);

            //Покрышки
            var CountTires = new user16Entities1().product.Where(
                x => x.id == 37 || x.id == 38).Sum(x => x.quantity);

            GeneralCountTxbTires.Text = Convert.ToString(CountTires);
        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.GoBack();
        }

        private void RefreshPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Refresh();
        }

        private void WheelsBtn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WheelsBtn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WheelsBtn3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WheelsBtn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WheelsBtn5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void TireBtn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TireBtn2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
