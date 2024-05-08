using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("avtomobilnyy.spravochnik@mail.ru");

            MailAddress to = new MailAddress("avtomobilnyy.spravochnik@mail.ru");

            using (MailMessage message = new MailMessage(from, to))

            using (SmtpClient smpt = new SmtpClient())
            {


            }
        }
    }
}
