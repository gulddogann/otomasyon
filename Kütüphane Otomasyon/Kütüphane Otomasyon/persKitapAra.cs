using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kütüphane_Otomasyon
{
    public partial class persKitapAra : Form
    {
        public persKitapAra()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();

        private void button1_Click(object sender, EventArgs e)
        { 
            //kitap filtrelemede sorun var
            try
            {
                MySqlCommand command = new MySqlCommand("select * from Kitap where kitapid =" + Convert.ToInt32(kitapNoTxt.Text), baglanti.Baglan());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Değerleri doğru girdiğinizden emin olun");

            }
            catch (System.TimeoutException)
            {
                MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olun");
            }

        }

        private void kitapNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void persKitapAra_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("select * from Kitap", baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelEkrani fr = new personelEkrani();
            fr.Show();
            this.Hide();
        }
    }
}
