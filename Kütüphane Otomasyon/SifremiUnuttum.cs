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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti baglanti = new Baglanti();

            if (eposbir.Text == "")
            {
                MessageBox.Show("E-Postanızı giriniz");
            }
            if (eposiki.Text == "")
            {
                MessageBox.Show("E-Posta türünü belirtiniz");
            }
            else
            {
                string eposta = eposbir.Text + eposiki.Text;

                try
                {
                    MySqlCommand sqlCommand = new MySqlCommand("select * from Personel where personelad=@p1 and personelsoyad=@p2 and personeltelno=@p3 and perid=@p4 and personeleposta=@p5", baglanti.Baglan());
                    sqlCommand.Parameters.AddWithValue("@p1", perad.Text.ToLower());
                    sqlCommand.Parameters.AddWithValue("@p2", persoyad.Text.ToLower());
                    sqlCommand.Parameters.AddWithValue("@p3", telno.Text);
                    sqlCommand.Parameters.AddWithValue("@p4", Convert.ToInt32(perid.Text));
                    sqlCommand.Parameters.AddWithValue("@p5", eposta.ToLower());
                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        sifre.Text = reader["personelsifre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş!", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("ID niz sayılardan oluşmalı","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
            }
        }

        private void perid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void perad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void persoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelGiris ekrani = new personelGiris();
            ekrani.Show();
            this.Hide();
        }
    }
}
