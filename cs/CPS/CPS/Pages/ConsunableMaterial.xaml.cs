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
    /// Логика взаимодействия для ConsunableMaterial.xaml
    /// </summary>
    public partial class ConsunableMaterial : Page
    {
        public ConsunableMaterial()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 450;
            Application.Current.MainWindow.Width = 800;
            MinWidth = 800;
            MinHeight = 450;
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

        private void Smell_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Запах");
        }

        private void Oil_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Масло");
        }

        private void GlassWasher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Стеклоомывайка");
        }

        private void NonFreezing_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Незамерзайка");
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
