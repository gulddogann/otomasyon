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
    public partial class Kitap_ekle : Form
    {
        public Kitap_ekle()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(80, 0);
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");
        private void kitapekle_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Kitap (kitapid,kitapadi,yayinadi,stoksayisi,sayfasayisi,kutupektarihi,dil,yazar,cevirmen,editor,rafno,sutun) values (@p1,@p2,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)",conn);
            cmd.Parameters.AddWithValue("@p1",Convert.ToInt32(barkod_no.Text));
            cmd.Parameters.AddWithValue("@p2",kitap_ad.Text);
            cmd.Parameters.AddWithValue("@p4",yayınevi.Text);
            cmd.Parameters.AddWithValue("@p5",Convert.ToInt32(stok_sayısı.Text));
            cmd.Parameters.AddWithValue("@p6",Convert.ToInt32(kitap_sayfa.Text));
            cmd.Parameters.AddWithValue("@p7",kitapektar.Value);
            cmd.Parameters.AddWithValue("@p8",kitap_dil.Text);
            cmd.Parameters.AddWithValue("@p9",yazar_ad.Text);
            cmd.Parameters.AddWithValue("@p10",cevirmenadı.Text);
            cmd.Parameters.AddWithValue("@p11",editoradı.Text);
            cmd.Parameters.AddWithValue("@p12",Convert.ToInt32(kitap_rafno.Text));
            cmd.Parameters.AddWithValue("@p13",Convert.ToInt32(kitap_sütun_no.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Eklendi");
        }

        private void kitapsil_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("delete from Kitap where kitapid = @p1", conn);
            mySqlCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox2.Text));
            mySqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Silindi");
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            barkod_no.Clear();
            kitap_ad.Clear();
            cevirmenadı.Clear();
            kitap_sayfa.Clear();
            editoradı.Clear();
            kitap_kategori.Clear();
            yayınevi.Clear();
            kitap_dil.Clear();
            stok_sayısı.Clear();
            kitap_rafno.Clear();
            kitap_sütun_no.Clear();
            yazar_ad.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;

            string no = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string yayınadı = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string stok = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string sayfasayisi = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            string kutupektar = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            string dil = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            string yazar = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            string cevirmen = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();
            string editor = dataGridView1.Rows[seçilialan].Cells[9].Value.ToString();
            string rafno = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
            string sutun = dataGridView1.Rows[seçilialan].Cells[11].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand sqlCommand = new MySqlCommand("update Kitap set () where kitapid=",conn);

            conn.Close();
        }

        private void Kitap_ekle_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.";
            string sql = "SELECT * FROM Kitap";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(sCommand);
            MySqlCommandBuilder sBuilder = new MySqlCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "Kitap");
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["Kitap"];
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        
    }
}
