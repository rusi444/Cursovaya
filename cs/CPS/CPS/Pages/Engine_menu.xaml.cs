//using DevExpress.Utils.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;

namespace CPS
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 450;
                                        MinHeight = 450;

            Application.Current.MainWindow.Width = 800;
                                        MinWidth = 800;
            BtnBackPage.Content = "<<";
            DataContext = new Class2();
        }
        private void BtnBackPage_Click(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            var name = p1.TextBoxFirst.Text;
            Class1.frame.Navigate(new Page2(name));
        }

        private void Engine_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("поршни");;
        }

        private void spark_plugs_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("свечки");
        }

        private void filters_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("фильтры");
        }


        private void starter_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("стартер");
        }

        private void oil_pan_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("масляной поддон");
        }

        private void other_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("other");
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        //private void contact_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    // создать табл в бд по делу обращению
        //    Class1.frame.Navigate(new contact());
        //}
    }
}
