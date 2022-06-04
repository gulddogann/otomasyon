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
    public partial class kitapAlVer : Form
    {
        public kitapAlVer()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            if(ogrNoTxt.Text.Length>9)
            {
                MessageBox.Show("Öğrenci ID si çok uzun");
            }
            if(ogrNoTxt.Text.Length==9)
            {
                MySqlCommand command = new MySqlCommand("select OgrenciKitap.ogrid,OgrenciKitap.kitapid from OgrenciKitap inner join Kitap on OgrenciKitap.kitapid=Kitap.kitapid where OgrenciKitap.ogrid=@p1 and OgrenciKitap.kitapid=@p2 and Kitap.kitapdurum=1", baglanti.Baglan());
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(ogrNoTxt.Text));
                command.Parameters.AddWithValue("@p2", Convert.ToInt32(kitapAdTxt.Text));
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (ogrNoTxt.Text == reader["ogrid"].ToString() && kitapAdTxt.Text == reader["kitapid"].ToString())
                    {
                        MessageBox.Show("Kitap zaten verilmiş", "UYARI!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into OgrenciKitap(ogrid,kitapid,verilentarih,alınantarih)values(@p1,@p2,@p3,@p4)", baglanti.Baglan());
                        cmd.Parameters.AddWithValue("@p1", (Convert.ToInt32(ogrNoTxt.Text)));
                        cmd.Parameters.AddWithValue("@p2", (Convert.ToInt32(kitapAdTxt.Text)));
                        cmd.Parameters.AddWithValue("@p3", (teslimDtp.Value));
                        cmd.Parameters.AddWithValue("@p4", (iadeDtp.Value));
                        cmd.ExecuteNonQuery();

                        MySqlCommand cmd1 = new MySqlCommand("update Kitap inner join OgrenciKitap on Kitap.kitapid=OgrenciKitap.kitapid set Kitap.kitapdurum=1 where OgrenciKitap.kitapid=@p1 and OgrenciKitap.ogrid=@p2", baglanti.Baglan());
                        cmd1.Parameters.AddWithValue("@p1", Convert.ToInt32(kitapAdTxt.Text));
                        cmd1.Parameters.AddWithValue("@p2", Convert.ToInt32(ogrNoTxt.Text));
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Kitap teslim edildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.TimeoutException)
                    {
                        MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (System.OverflowException)
                    {
                        MessageBox.Show("Değerleri Doğru girdiğinizden emin olun", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                }
                kitapAdTxt.Clear();
                ogrNoTxt.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("update Kitap inner join OgrenciKitap on Kitap.kitapid=OgrenciKitap.kitapid set Kitap.kitapdurum=0 where OgrenciKitap.kitapid=@p1 and OgrenciKitap.ogrid=@p2", baglanti.Baglan());
                cmd1.Parameters.AddWithValue("@p1", Convert.ToInt32(kitapAdTxt.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Kitap teslim alındı");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            kitapAdTxt.Clear();
            ogrNoTxt.Clear();
            
        }

        private void kitapAlVer_Load(object sender, EventArgs e)
        {
            iadeDtp.Value = iadeDtp.Value.AddDays(15);
        }

        private void ogrNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitapAdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelEkrani fr = new personelEkrani();
            fr.Show();
            this.Hide();
        }
    }
}
