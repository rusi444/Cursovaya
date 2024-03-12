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
    public partial class Wheels : Page
    {
        public Wheels()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 450;
                                        MinHeight = 450;

            Application.Current.MainWindow.Width = 800;
                                        MinWidth = 800;

            gobackbtn.Content = "<<";

            DataContext = new Class2();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            var name = p1.TextBoxFirst.Text;
            Class1.frame.Navigate(new Page2(name));
        }

        private void WheelsBut_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new CP_Wheels());
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
