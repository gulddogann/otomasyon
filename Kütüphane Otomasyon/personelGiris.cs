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
    public partial class personelGiris : Form
    {
        public personelGiris()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            personelEkrani personelEkrani = new personelEkrani();

            try
            {
                MySqlCommand command = new MySqlCommand("select * from Personel where perid=@p1 and personelsifre=@p2", baglanti.Baglan());
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(personelAdTxt.Text));
                command.Parameters.AddWithValue("@p2", personelSifreTxt.Text);
                MySqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    personelEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş", "UYARI!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ID niz sayılardan oluşmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (System.TimeoutException)
            {
                MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum unuttum = new SifremiUnuttum();
            unuttum.Show();
            this.Hide();
        }

        private void personelAdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonelKayıt personelKayıt = new PersonelKayıt();
            personelKayıt.Show();
            this.Hide();
        }

        private void personelAdTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
