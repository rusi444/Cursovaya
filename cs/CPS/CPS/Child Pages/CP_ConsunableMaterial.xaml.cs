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

namespace CPS.Child_Pages
{
    /// <summary>
    /// Логика взаимодействия для CP_ConsunableMaterial.xaml
    /// </summary>
    public partial class CP_ConsunableMaterial : Page
    {
        public CP_ConsunableMaterial()
        {
            InitializeComponent();
            gobackbtn.Content = "<<";
            MinHeight = 700;
            MinWidth = 600;
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.GoBack();
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

        private void FirstCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SecondCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThirdCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FourthCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FiveCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SixCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SeventhCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EigthCons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Refresh();
        }
    }
}
