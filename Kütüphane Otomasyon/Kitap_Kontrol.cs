using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu__bu_son_
{
    public partial class Kitap_Kontrol : Form
    {
        public Kitap_Kontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mail_Gönder mail_Gönder = new Mail_Gönder();
            mail_Gönder.Show();
        }

        private void Kitap_Kontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
