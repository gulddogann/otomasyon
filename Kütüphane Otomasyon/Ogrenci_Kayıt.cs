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

namespace Kütüphane_Otomasyonu__bu_son_
{
    public partial class Ogrenci_Kayıt : Form
    {
        public Ogrenci_Kayıt()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(230, 0);
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");

        private void kayıt_ol_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Ogrenci (ogrid,ograd,ogrsoyad,ogrposta,ogrbolumad,ogrtel) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(ogrenci_no.Text));
            cmd.Parameters.AddWithValue("@p2", ogrenci_ad.Text);
            cmd.Parameters.AddWithValue("@p3", ogrenci_soyad.Text);
            cmd.Parameters.AddWithValue("@p4", ogrenci_posta.Text);
            cmd.Parameters.AddWithValue("@p5", ogrenci_bolum.Text);
            cmd.Parameters.AddWithValue("@p6", ogrenci_telno.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kaydedildi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("delete from Ogrenci where ogrid = @p1", conn);
            mySqlCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
            mySqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Silindi");
        }
    }
}
