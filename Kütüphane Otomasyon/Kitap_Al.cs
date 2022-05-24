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
    public partial class Kitap_Al : Form
    {
        public Kitap_Al()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("delete from OgrenciKitap where kitapid = @p1 and ogrid=@p2", conn);
            cmd.Parameters.AddWithValue("@p1",Convert.ToInt32(textBox3.Text));
            cmd.Parameters.AddWithValue("@p2",Convert.ToInt32(textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            MySqlCommand command = new MySqlCommand("update Kitap set kitapdurum=0 where kitapid=@p1", conn);
            command.Parameters.AddWithValue("@p1",Convert.ToInt32(textBox3.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Alındı");

        }
    }
}
