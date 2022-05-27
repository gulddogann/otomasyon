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
    public partial class Kitap_Ara : Form
    {
        public Kitap_Ara()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0,400);
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");
        private void kitapara_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command= new MySqlCommand("select * from Kitap where kitapadi like '%" + Kitapadi.Text + "%' and sayfasayisi = " + Convert.ToInt32(Kitapsayfasi.Text), conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Kitap_Ara_Load(object sender, EventArgs e)
        {

        }
    }
}
