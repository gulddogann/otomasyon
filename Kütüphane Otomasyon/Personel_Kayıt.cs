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
    public partial class Personel_Kayıt : Form
    {
        public Personel_Kayıt()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");

        private void kayıtol_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Personel (personelad,personelsoyad,personeleposta,perid,personeltelno) values (@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1", perad.Text);
            cmd.Parameters.AddWithValue("@p2", persoyad.Text);
            cmd.Parameters.AddWithValue("@p3", perposta.Text);
            cmd.Parameters.AddWithValue("@p4", perno.Text);
            cmd.Parameters.AddWithValue("@p5", pertelno.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kaydedildi");
        }
    }
}
