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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public string raporIstatistik = "";


        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = raporIstatistik;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
