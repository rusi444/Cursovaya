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
    /// Логика взаимодействия для CP_Acoustic.xaml
    /// </summary>
    public partial class CP_Acoustic : Page
    {
        DispatcherTimer _timer = new DispatcherTimer();

        public CP_Acoustic()
        {
            InitializeComponent();
            MinHeight = 700;
            MinWidth = 600;
            DataContext = new Class2();
            gobackbtn.Content = "<<";
            Class1.conbd = new user16Entities1();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _timer.Interval = TimeSpan.FromSeconds(0.1);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            //var count =
            //from parts in new user16Entities1().parts
            //where parts.name == "Сабвуферы"
            //select new { parts.quantity };

            var count = new user16Entities1().parts.Where(x => x.name == "Сабвуферы"
            || x.name == "Колонки авто.").Sum(x => x.quantity);

            CountGeneralSubTxb.Text = Convert.ToString(count);
        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.GoBack();
        }

        private void PionereWXBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Качество" +
                " 150 Вт усилителя MOSFET обеспечивает мощные басы, а корпус," +
                " усиленный отлитым под давлением алюминиевым радиатором обеспечивает" +
                " прекрасные звуковые характеристики без помех.", "пеонер)",
                MessageBoxButton.YesNo);

            if (Result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Товар добавлен в Вашу корзину", "саксефул");
            }
            else if (Result == MessageBoxResult.No)
            {
                // ну нет так нет, пошел вон
            }
        }

        private void SecondAcoust_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("какая то колонка, сабвуфер", "колоночка)",
                MessageBoxButton.YesNo);

            if (Result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Товар добавлен в Вашу корзину", "саксефул");
            }
            else if (Result == MessageBoxResult.No)
            {
                // ну нет так нет, пошел вон
            }
        }

        private void ThirdAcoust_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("какая то колонка, сабвуфер", "колоночка)",
                MessageBoxButton.YesNo);

            if (Result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Товар добавлен в Вашу корзину", "саксефул");
            }
            else if (Result == MessageBoxResult.No)
            {
                // ну нет так нет, пошел вон
            }
        }

        private void FourthAcoust_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("какая то колонка, сабвуфер", "колоночка)",
                MessageBoxButton.YesNo);

            if (Result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Товар добавлен в Вашу корзину", "саксефул");
            }
            else if (Result == MessageBoxResult.No)
            {
                // ну нет так нет, пошел вон
            }
        }

        private void RefreshPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Refresh();
        }
    }
}
