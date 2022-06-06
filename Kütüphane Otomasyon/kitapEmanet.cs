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
            
            MySqlCommand cmd = new MySqlCommand("select kitapid ,kitapadi ,yayinadi ,sayfasayisi ,kutupektarihi ,dil ,yazar ,cevirmen ,editor ,rafno ,sutun ,kitapdurum ,Kategori)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)",Baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@p1",idTxt.Text);
            cmd.Parameters.AddWithValue("@p2",adTxt.Text);
            cmd.Parameters.AddWithValue("@p3",yayinTxt.Text);
            cmd.Parameters.AddWithValue("@p4",sayfaTxt.Text);
            cmd.Parameters.AddWithValue("@p5",eklentarTxt.Text);
            cmd.Parameters.AddWithValue("@p6",dilTxt.Text);
            cmd.Parameters.AddWithValue("@p7",yazarTxt.Text);
            cmd.Parameters.AddWithValue("@p8",cevirmenTxt.Text);
            cmd.Parameters.AddWithValue("@p9",editorTxt.Text);
            cmd.Parameters.AddWithValue("@p10",rafTxt.Text);
            cmd.Parameters.AddWithValue("@p11",sutunTxt.Text);
            cmd.Parameters.AddWithValue("@p12",durumTxt.Text);
            cmd.Parameters.AddWithValue("@p13",katTxt.Text);



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
