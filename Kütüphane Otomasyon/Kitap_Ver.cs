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
    public partial class Kitap_Ver : Form
    {
        public Kitap_Ver()
        {
            InitializeComponent();
        }

        private void Kitap_Ver_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = dateTimePicker1.Value.ToString();
            //maskedTextBox2.Text = Convert.ToString(Convert.ToInt32(maskedTextBox1.Text)+15);
        }
    }
}
