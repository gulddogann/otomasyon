using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Kütüphane_Otomasyonu__bu_son_
{
    public partial class Mail_Gönder : Form
    {
        public Mail_Gönder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(textBox1.Text);
            mailMessage.To.Add(textBox2.Text);
            mailMessage.Subject = "Konu";
            mailMessage.Body = richTextBox1.Text;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential(textBox1.Text,"newyork70");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            object o = mailMessage;

            try
            {
                smtpClient.SendAsync(mailMessage, (object)mailMessage);
                //smtpClient.Send(mailMessage);
                MessageBox.Show("gönderildi");
            }
            catch (SmtpException ex)
            {

                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
        }
    }
}
