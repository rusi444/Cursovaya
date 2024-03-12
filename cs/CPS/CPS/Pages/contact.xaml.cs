using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Логика взаимодействия для contact.xaml
    /// </summary>
    public partial class contact : Page
    {
        public contact()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 350;
            Application.Current.MainWindow.Width = 400;
            MinHeight = 350;
            MinWidth = 400;
            gobackbtn.Content = "<<";
            DataContext = new Class2();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxcontact.Text) && string.IsNullOrWhiteSpace(name_cl.Text))
            {
                MessageBox.Show("Заполните строку имени, \nи введите сообщение", "Сообщение");
            }
            else if (string.IsNullOrWhiteSpace(textboxcontact.Text))
            {
                MessageBox.Show("Введите сообщение", "Сообщение");
            }
            else if (string.IsNullOrWhiteSpace(name_cl.Text))
            {
                MessageBox.Show("Введите Ваше имя", "Сообщение");
            }
            else
            {
                MailAddress fromAddress = new MailAddress("pharaonixxx@mail.ru", $"{name_cl.Text}");
                MailAddress toAddress = new MailAddress("L3or5@mail.ru", "l3or5");
                MailMessage message = new MailMessage(fromAddress, toAddress);
                message.Body = $"{textboxcontact.Text}";
                message.Subject = "Сообщение от пользователя программы автоматизации автомагазина";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.mail.ru";
                smtpClient.Port = 25;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromAddress.Address, "uBCEcgLnAprSraR8pgZN");

                smtpClient.Send(message);
                MessageBox.Show("Сообщение отправлено", "Успешно!");



                //var userObj = Class1.conbd.contact.FirstOrDefault(
                //        x => x.contact_with_client == textboxcontact.Text &&
                //        x.name_client == textboxcontact.Text);
                //try
                //{
                //    if (userObj == null)
                //    {
                //        userObj = Class1.conbd.contact.FirstOrDefault();
                //        userObj.contact_with_client = textboxcontact.Text;
                //        userObj.name_client = name_cl.Text;
                //        Class1.conbd.contact.Add(userObj);
                //        Class1.conbd.SaveChanges(); 
                //        MessageBox.Show("Сообщение успешно отправлено!", "Сообщение");
                //    }

                //    else
                //    {

                //    }
                //}

                //catch
                //{

                //}
            }
        }

        private void gobackbtn_Click(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            var name = p1.TextBoxFirst.Text;
            Class1.frame.Navigate(new Page2());
        }

        private void textboxcontact_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountLbl.Content = textboxcontact.Text.Length + " / 150";
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
