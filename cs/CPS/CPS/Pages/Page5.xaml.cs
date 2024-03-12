using DevExpress.Xpf.Editors;
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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 450;
            Application.Current.MainWindow.Width = 800;
            //MinWidth = 800;
            //MinHeight = 450;
            gobackbtn.Content = "<<";
            DataContext = new Class2();
        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            var name = p1.TextBoxFirst.Text;
            Class1.frame.Navigate(new Page2(name));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Polygon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test1");
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test1");
        }

        private void Label_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test1");
        }

        private void Polygon_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test2");
        }

        private void Label_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test2");
        }

        private void Label_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test2");
        }

        private void Polygon_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test3");
        }

        private void Label_MouseLeftButtonUp_4(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test3");
        }

        private void Label_MouseLeftButtonUp_5(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test3");
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
