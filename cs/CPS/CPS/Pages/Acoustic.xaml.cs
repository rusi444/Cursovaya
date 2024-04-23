using CPS.Child_Pages;

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

namespace CPS
{
    /// <summary>
    /// Логика взаимодействия для Acoustic.xaml
    /// </summary>
    public partial class Acoustic : Page
    {
        public Acoustic()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 700;
            Application.Current.MainWindow.Width = 650;
            MinWidth = 650;
            MinHeight = 700;
            gobackbtn.Content = "<<";
            DataContext = new Class2();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.GoBack();
        }

        private void SubFoower_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new CP_Acoustic());
        }

        private void kolonki_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new CP_Acoustic());
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Закрыть окно?", "Уведомление", MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else if (Result == MessageBoxResult.No)
            {

            }
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
