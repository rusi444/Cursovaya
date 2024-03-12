using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using System.Xml.Linq;
using System.Threading;
using static CPS.Page3;
using System.Timers;

namespace CPS
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 500;
            Application.Current.MainWindow.Width = 400;
            MinHeight = 500;
            MinWidth = 400;


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_Tick;
            timer.Start();
            DataContext = new Class2();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Reg2LogTxb.Text.Length == 0)
            {
                Reg2logLabel.Visibility = Visibility.Hidden;
                MyFading1.Visibility = Visibility.Visible;
            }
            else
            {
                MyFading1.Visibility = Visibility.Hidden;
                Reg2logLabel.Visibility = Visibility.Visible;
            }


            if (Reg2PasswTxb.Text.Length == 0)
            {
                Reg2PasswLabel.Visibility = Visibility.Hidden;
                MyFading2.Visibility = Visibility.Visible;
            }
            else
            {
                MyFading2.Visibility = Visibility.Hidden;
                Reg2PasswLabel.Visibility = Visibility.Visible;
            }
        }


        private void Reg2PasswTxb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Reg2LogTxb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Old_Click(object sender, RoutedEventArgs e)
        {
            Class1.frame.Navigate(new Page1());
        }

        private void Registration_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Reg2PasswTxb.Text) && (string.IsNullOrWhiteSpace(Reg2LogTxb.Text)))
            {
                MessageBox.Show("Введите данные.", "Сообщение");
            }
            else if (string.IsNullOrWhiteSpace(Reg2PasswTxb.Text))
            {
                MessageBox.Show("Введите пароль.", "Сообщение");
            }
            else if (string.IsNullOrWhiteSpace(Reg2LogTxb.Text))
            {
                MessageBox.Show("Введите логин.", "Сообщение");
            }
            else
            {
                var userObj = Class1.conbd.user.FirstOrDefault(
                        x => x.login == Reg2LogTxb.Text &&
                        x.password == Reg2PasswTxb.Text);

                var user = Class1.conbd.user.FirstOrDefault(
                        x => x.login == Reg2LogTxb.Text);

                try
                {
                    if (user == null)
                    {
                        userObj = Class1.conbd.user.FirstOrDefault();
                        userObj.login = Reg2LogTxb.Text;
                        userObj.password = Reg2PasswTxb.Text;
                        userObj.IDrole = 2;
                        Class1.conbd.user.Add(userObj);
                        Class1.conbd.SaveChanges();
                        MessageBox.Show("Вы успешно зарегистрировались", "Успешно");
                        Class1.frame.Navigate(new Page1());
                    }
                    else
                    {
                            MessageBox.Show("Пользователь с таким логином уже зарегистрирован.");
                    }
                }
                catch
                {

                }
            }
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
