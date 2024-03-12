//using DevExpress.Data;
//using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
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

namespace CPS
{
    public partial class Page2 : Page
    {
        static string _name;

        public Page2(string name="")
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 800;
            Application.Current.MainWindow.Width = 500;
            switcah.Content = "Что тебя интересует?";
            if(string.IsNullOrEmpty(_name))
                _name = name;
            DataContext = new Class2();



            //switcah.HorizontalAlignment = HorizontalAlignment.Center;
            //switcah.HorizontalContentAlignment = HorizontalAlignment.Center;


            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour <= 12)
            {
                LabelWelcome.Content = $"Доброе утро {_name}";
            }
            else if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour <= 17)
            {
                LabelWelcome.Content = $"Добрый день {_name}";
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 22)
            {
                LabelWelcome.Content = $"Добрый вечер {_name}";
            }
            else if (DateTime.Now.Hour >= 23 && DateTime.Now.Hour <= 4)
            {
                LabelWelcome.Content = $"Доброй ночи {_name}";
            }
        }

        private void frameMain_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Wheels_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new Wheels());
        }

        private void Beaux_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new Page5());
        }

        private void Engine_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new Page4());
        }

        private void Music_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new Acoustic());
        }

        private void Rashodnik_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new ConsunableMaterial());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
                from parts in new user16Entities1().parts
                orderby parts.name, parts.quantity
                select new { parts.name, parts.quantity };
            DG1.ItemsSource = query.ToList();
        }

        private void contact_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Class1.frame.Navigate(new contact());
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
