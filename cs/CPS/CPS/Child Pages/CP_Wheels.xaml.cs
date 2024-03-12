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
    /// Логика взаимодействия для CP_Wheels.xaml
    /// </summary>
    public partial class CP_Wheels : Page
    {
        public CP_Wheels()
        {
            InitializeComponent();
            MinHeight = 700;
            MinWidth = 600;
            DataContext = new Class2();
            gobackbtn.Content = "<<";
        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.GoBack();
        }

    }
}
