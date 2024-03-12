using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
using System.Windows.Threading;

namespace CPS
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Class1.conbd = new user16Entities1();
            Application.Current.MainWindow.Height = 500;
            Application.Current.MainWindow.Width = 400;
            MinHeight = 500;
            MinWidth = 400;
            DataContext = new Class2();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (LogTxb.Text.Length == 0)
            {
                loglabel.Visibility = Visibility.Hidden;
                MyFading1.Visibility = Visibility.Visible;
            }
            else
            {
                MyFading1.Visibility = Visibility.Hidden;
                loglabel.Visibility = Visibility.Visible;
            }


            if (PasswTxb.Text.Length == 0)
            {
                passwlabel.Visibility = Visibility.Hidden;
                MyFading2.Visibility = Visibility.Visible;
            }
            else
            {
                MyFading2.Visibility = Visibility.Hidden;
                passwlabel.Visibility = Visibility.Visible;
            }
        }


        private void ButtonFirst_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxFirst.Text))
            {
                MessageBox.Show("Введите имя, пожалуйста", "Сообщение");
            }
            else if (string.IsNullOrEmpty(PasswTxb.Text) || string.IsNullOrEmpty(LogTxb.Text))
            {
                MessageBox.Show("Заполните все поля.", "Синтаксис");
                
            }
            else if (!string.IsNullOrEmpty(PasswTxb.Text) && !string.IsNullOrEmpty(LogTxb.Text))
            {
                // авторизация
                try
                {
                    var userObj = Class1.conbd.user.FirstOrDefault(
                        x => x.login == LogTxb.Text &&
                        x.password == PasswTxb.Text);

                    if (userObj != null && userObj.IDrole != 1)
                    {
                        Class1.frame.Navigate(new Page2(TextBoxFirst.Text));
                        //Class1.frame.Navigate(new Wheels());
                    }

                    else if (userObj == null)
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка");
                    }

                    else if (userObj.IDrole == 1)
                    {
                        MessageBox.Show("Администратор");
                    }

                    else
                    {
                        MessageBox.Show("Неизвестная ошибка", "Не удалось");
                    }

                }
                catch
                {
                    MessageBox.Show("Неизвестная ошибка!", "Не удалось!");
                }
            }
        }

        private void YesBtn_Click(object sender, RoutedEventArgs e) // "да был" - авторизация
        {
            Olden.Visibility = Visibility.Hidden;
            Auth.Visibility = Visibility.Visible;
        }

        private void NoBtn_Click(object sender, RoutedEventArgs e) // "я здесь впервые" - регистрация
        {
                Class1.frame.Navigate(new Page3());
        }


        private void Olden2Btn_Click(object sender, RoutedEventArgs e) // "я здесь впервые" - регистрация
        {
                Class1.frame.Navigate(new Page3());
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
