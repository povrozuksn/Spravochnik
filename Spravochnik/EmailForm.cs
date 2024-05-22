using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("avtomobilnyy.spravochnik@mail.ru");

            if(AdressTextBox.Text == "")
            {
                MessageBox.Show("Введите адресс Email");
            }
            else
            {
                MailAddress to = new MailAddress(AdressTextBox.Text);

                using (MailMessage message = new MailMessage(from, to))

                using (SmtpClient smtp = new SmtpClient())
                {
                    message.Subject = "Ваш список сравнения";
                    message.Body = "Здравстуйте. " + Environment.NewLine + "Мы прислали Вам Ваш список";
                    message.IsBodyHtml = true;

                    File.AppendAllText("Список.csv", "Название;Количество;Цена");
                    foreach(KeyValuePair<Car, int> selectcar in CompareForm.myCars_list)
                    {
                        Car car = selectcar.Key;
                        File.AppendAllText("Список.csv", Environment.NewLine + 
                            car.name + ";" + selectcar.Value + ";" + car.price);
                    }

                    message.Attachments.Add(new Attachment("Список.csv"));

                    smtp.Host = "smtp.mail.ru";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(from.Address, "i9fPDuZtXYHPi7A6pvLW");

                    smtp.Send(message);
                }
            }
            
            MessageBox.Show("Письмо отправлено");
            Close();
        }
    }
}
