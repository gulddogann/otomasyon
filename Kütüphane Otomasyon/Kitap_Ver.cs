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
    public partial class Kitap_Ver : Form
    {
        public Kitap_Ver()
        {
            InitializeComponent();
        }

        private void Kitap_Ver_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(15);
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into OgrenciKitap (ogrid,kitapid,verilentarih) values (@p1,@p2,@p3)",conn);
            mySqlCommand.Parameters.AddWithValue("@p1",Convert.ToInt32(ogrno.Text));
            mySqlCommand.Parameters.AddWithValue("@p2",Convert.ToInt32(kitapno.Text));
            mySqlCommand.Parameters.AddWithValue("@p3",dateTimePicker1.Value);
            mySqlCommand.Parameters.AddWithValue("@p4",dateTimePicker2.Value);
            mySqlCommand.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update Kitap set kitapdurum=1 where kitapid=@p1",conn);
            cmd.Parameters.AddWithValue("@p1",Convert.ToInt32(kitapno.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Verildi");
        }
    }
}
