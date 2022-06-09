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
                    if (ogrNoTxt.Text == reader["ogrid"].ToString() || kitapAdTxt.Text == reader["kitapid"].ToString())
                    {
                        MessageBox.Show("Kitap zaten verilmiş", "UYARI!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MySqlCommand cmd; cmd = new MySqlCommand("insert into OgrenciKitap(ogrid,kitapid,verilentarih,alınantarih,gün,ay,yıl)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti.Baglan());

                    cmd.Parameters.AddWithValue("@p1", (Convert.ToInt32(ogrNoTxt.Text)));
                    cmd.Parameters.AddWithValue("@p2", (Convert.ToInt32(kitapAdTxt.Text)));
                    cmd.Parameters.AddWithValue("@p3", (teslimDtp.Value));
                    cmd.Parameters.AddWithValue("@p4", (iadeDtp.Value));
                    cmd.Parameters.AddWithValue("@p5", (iadeDtp.Value.Day));
                    cmd.Parameters.AddWithValue("@p6", (iadeDtp.Value.Month));
                    cmd.Parameters.AddWithValue("@p7", (iadeDtp.Value.Year));

                    MySqlCommand cmd1 = new MySqlCommand("update Kitap inner join OgrenciKitap on Kitap.kitapid=OgrenciKitap.kitapid set Kitap.kitapdurum=1 where OgrenciKitap.kitapid=@p1 and OgrenciKitap.ogrid=@p2", baglanti.Baglan());
                    cmd1.Parameters.AddWithValue("@p1", Convert.ToInt32(kitapAdTxt.Text));
                    cmd1.Parameters.AddWithValue("@p2", Convert.ToInt32(ogrNoTxt.Text));
                    MessageBox.Show("Kitap teslim edildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                    }
                    catch (System.TimeoutException)
                    {
                        MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (System.OverflowException)
                    {
                        MessageBox.Show("Değerleri Doğru girdiğinizden emin olun", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    catch(MySql.Data.MySqlClient.MySqlException)
                    {
                        MessageBox.Show("Üye Kayıt edilmemiş!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                tablo();

                kitapAdTxt.Clear();
                ogrNoTxt.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                MySqlCommand cmd1 = new MySqlCommand("update Kitap inner join OgrenciKitap on Kitap.kitapid=OgrenciKitap.kitapid set Kitap.kitapdurum=0 where OgrenciKitap.kitapid=@p1 and OgrenciKitap.ogrid=@p2", baglanti.Baglan());
                cmd1.Parameters.AddWithValue("@p1", Convert.ToInt32(kitapAdTxt.Text));
                cmd1.Parameters.AddWithValue("@p2", Convert.ToInt32(ogrNoTxt.Text));
                cmd1.ExecuteNonQuery();

                MySqlCommand command = new MySqlCommand("delete from OgrenciKitap where ogrid=@p2 and kitapid=@p1", baglanti.Baglan());
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(kitapAdTxt.Text));
                command.Parameters.AddWithValue("@p2", Convert.ToInt32(ogrNoTxt.Text));
            command.ExecuteNonQuery();
                MessageBox.Show("Kitap teslim alındı");
                tablo();
            
            kitapAdTxt.Clear();
            ogrNoTxt.Clear();
            
        }

        public void tablo()
        {
            MySqlCommand cmd2 = new MySqlCommand("select OgrenciKitap.ogrid,OgrenciKitap.kitapid,OgrenciKitap.verilentarih,OgrenciKitap.alınantarih from Kitap inner join OgrenciKitap on Kitap.kitapid=OgrenciKitap.kitapid where Kitap.kitapdurum=1", baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            DataSet dts = new DataSet();
            adapter.Fill(dts);
            dataGridView4.DataSource = dts.Tables[0];
        }
        private void kitapAlVer_Load(object sender, EventArgs e)
        {
            iadeDtp.Value = iadeDtp.Value.AddDays(15);

            MySqlCommand command = new MySqlCommand("select Ogrenci.ogrid,Ogrenci.ograd,Ogrenci.ogrsoyad,Ogrenci.ogrtel,Ogrenci.ogrposta,Ogrenci.meslek,Ogrenci.ogrbolumad,Kitap.kitapid,Kitap.kitapadi,Kitap.rafno,Kitap.sutun from OgrenciKitap inner join Ogrenci on OgrenciKitap.ogrid=Ogrenci.ogrid inner join Kitap on Kitap.kitapid=OgrenciKitap.kitapid where gün<"+Convert.ToInt32(teslimDtp.Value.Day)+" and kitapdurum=1 and yıl="+Convert.ToInt32(teslimDtp.Value.Year)+" and ay="+Convert.ToInt32(teslimDtp.Value.Month)+"", baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            tablo();
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
