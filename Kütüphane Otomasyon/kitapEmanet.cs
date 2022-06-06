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
    public partial class kitapEmanet : Form
    {
        public kitapEmanet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapAlVer alVer = new kitapAlVer();
            alVer.Show();
            this.Hide();
        }

        private void kitapEmanet_Load(object sender, EventArgs e)
        {
            try
            {
                Baglanti baglanti = new Baglanti();

                string sql = "SELECT * FROM OgrenciKitap";

                MySqlCommand sCommand = new MySqlCommand(sql, baglanti.Baglan());
                MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
                MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
                DataSet sDs = new DataSet();
                sAdapter.Fill(sDs, "OgrenciKitap");
                dataGridView1.DataSource = sDs.Tables["OgrenciKitap"];
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelEkrani personel = new personelEkrani();
            personel.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
