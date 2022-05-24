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
    public partial class Öğrenci_Sil : Form
    {
        public Öğrenci_Sil()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");
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
