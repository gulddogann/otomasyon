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
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Kütüphane_Otomasyon
{
    public partial class ogrKayıtSil : Form
    {
        Baglanti baglanti = new Baglanti();
        public ogrKayıtSil()
        {
            InitializeComponent();
        }

        public void ogrtablo()
        {
            MySqlCommand cmd = new MySqlCommand("select ogrid as ID,ograd as Ad,ogrsoyad as Soyad,ogrposta as Eposta,ogrbolumad as Bolum,ogrtel as Telefon,meslek from Ogrenci", baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            adapter.Fill(dts);
            dataGridView1.DataSource = dts.Tables[0];
        }
        private void ogrKayıtSil_Load(object sender, EventArgs e)
        {
            ogrtablo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eposbir.Text == "")
            {
                MessageBox.Show("E-Postanızı giriniz");
            }
            if (eposiki.Text == "")
            {
                MessageBox.Show("E-Posta türünü belirtiniz");
            }
            if (eposbir.Text.Contains('@'))
            {
                MessageBox.Show("Eposta eposta türünü içeremez!", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                bolumadTxt.Text = "";
            }

            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("select * from Ogrenci where ogrtel=@p3", baglanti.Baglan());
                    command.Parameters.AddWithValue("@p3", telefonTxt.Text);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (telefonTxt.Text == reader["ogrtel"].ToString())
                        {
                            MessageBox.Show("Üye zaten Kaydedilmiş", "UYARI!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        }
                        else
                        { 
                            string eposta = eposbir.Text + eposiki.Text;

                            MySqlCommand cmd = new MySqlCommand("insert into Ogrenci (ogrid,ograd,ogrsoyad,ogrposta,ogrbolumad,ogrtel,meslek) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti.Baglan());

                            cmd.Parameters.AddWithValue("@p1", (Convert.ToInt32(ogrNoTxt.Text)));
                            cmd.Parameters.AddWithValue("@p2", (adTxt.Text));
                            cmd.Parameters.AddWithValue("@p3", (soyadTxt.Text));
                            cmd.Parameters.AddWithValue("@p4", (eposta));
                            cmd.Parameters.AddWithValue("@p5", (bolumadTxt.Text));
                            cmd.Parameters.AddWithValue("@p6", (telefonTxt.Text));
                            cmd.Parameters.AddWithValue("@p7", (comboBox1.Text));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Üye eklendi");
                            ogrtablo();
                        }
                    }                
                }
                catch (System.TimeoutException)
                {
                    MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olun", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Aynı No ya ait üye girilemez", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Değerleri doğru girdiğinizden emin olun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Üye numarası çok uzun", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("select * from Ogrenci where ogrid=@p1", baglanti.Baglan());
                    command.Parameters.AddWithValue("@p1", Convert.ToInt32(ogrSilTxt.Text));
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (Convert.ToInt32(ogrSilTxt.Text) != Convert.ToInt32(reader["ogrid"]))
                        {
                            MessageBox.Show("Üye Silinmiş veya hiç Eklenmemiş", "UYARI!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand("delete from Ogrenci where ogrid = @p1", baglanti.Baglan());
                            cmd.Parameters.AddWithValue("@p1", (ogrSilTxt.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kayıt silindi");
                            ogrtablo();
                        }
                    }

                    
                }
                catch(System.TimeoutException)
                {
                    MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olun","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void ogrNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void telefonTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrNoTxt.Clear();
            adTxt.Clear();
            soyadTxt.Clear();
            telefonTxt.Clear();
            comboBox1.ResetText();
            eposbir.Clear();
            eposiki.ResetText();
            bolumadTxt.ResetText();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelEkrani fr = new personelEkrani();
            fr.Show();
            this.Hide();
        }

        private void ogrSilTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bolumadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
    }
