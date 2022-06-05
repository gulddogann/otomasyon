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
    public partial class PersonelKayıt : Form
    {
        public PersonelKayıt()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();

        private void button1_Click(object sender, EventArgs e)
        {

            if(eposbir.Text=="")
            {
                MessageBox.Show("E-Postanızı giriniz");
            }
            if(eposiki.Text=="")
            {
                MessageBox.Show("E-Posta türünü belirtiniz");
            }
            if(eposbir.Text.Contains('@'))
            {
                MessageBox.Show("Eposta eposta türünü içeremez!", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }

            else
            {
                string eposta = eposbir.Text + eposiki.Text;

                try
                {
                    MySqlCommand command = new MySqlCommand("select * from Personel where personeltelno=@p3", baglanti.Baglan());
                    command.Parameters.AddWithValue("@p3", telno.Text);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (telno.Text == reader["personeltelno"].ToString())
                        {
                            MessageBox.Show("Üye zaten Kaydedilmiş", "UYARI!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MySqlCommand sqlCommand = new MySqlCommand("insert into Personel(personelad,personelsoyad,personeleposta,personeltelno,personelSifre,perid) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti.Baglan());
                            sqlCommand.Parameters.AddWithValue("@p1", perad.Text.ToLower());
                            sqlCommand.Parameters.AddWithValue("@p2", persoyad.Text.ToLower());
                            sqlCommand.Parameters.AddWithValue("@p3", eposta.ToLower());
                            sqlCommand.Parameters.AddWithValue("@p4", telno.Text);
                            sqlCommand.Parameters.AddWithValue("@p5", persifre.Text);
                            sqlCommand.Parameters.AddWithValue("@p6", Convert.ToInt32(textBox1.Text));
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Personel Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ID niz sayılardan oluşmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (System.TimeoutException)
                {
                    MessageBox.Show("internete bağlı olduğunuzdan emin olun", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Aynı ID tekrar girilemez","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                }
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            perad.Clear();
            persoyad.Clear();
            persifre.Clear();
            telno.Clear();
            eposbir.Clear();
            eposiki.ResetText();
            textBox1.Clear();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelGiris personel = new personelGiris();
            personel.Show();
            this.Hide();
        }
    }
}
