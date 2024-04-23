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
    /// Логика взаимодействия для CP_Engine.xaml
    /// </summary>
    public partial class CP_Engine : Page
    {
        public CP_Engine()
        {
            InitializeComponent();
            MinHeight = 450;
            MinWidth = 800;
            BtnBackPage.Content = "<<";
        }

        private void BtnBackPage_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.GoBack();
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
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

        private void FirstEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SecondEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThirdEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FourthEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FiveEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SixEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SeventhEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EigthEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NinethEng_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Refresh();
        }
    }
}
