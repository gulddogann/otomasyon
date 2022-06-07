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
        Baglanti baglanti = new Baglanti();
        
        public void Kitablo()
        {
            MySqlCommand command = new MySqlCommand("select * from Kitap", baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }
        private void kitapEmanet_Load(object sender, EventArgs e)
        {
            Kitablo();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelEkrani personel = new personelEkrani();
            personel.Show();
            this.Hide();
        }

        private void kitapNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitapAdiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void yayinAdiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void sayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dilTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void yazarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void cevirmenTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void editorTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void kategoriTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("update Kitap set kitapid="+Convert.ToInt32(kitapNoTxt.Text)+",kitapadi='"+kitapAdiTxt.Text.ToLower()+"',yayinadi='"+yayinAdiTxt.Text.ToLower()+"',sayfasayisi="+Convert.ToInt32(sayfaSayisi.Text)+",dil='"+dilTxt.Text.ToLower()+"',yazar='"+yazarTxt.Text.ToLower()+"',cevirmen='"+cevirmenTxt.Text.ToLower()+"',editor='"+editorTxt.Text.ToLower()+"',rafno="+Convert.ToInt32(rafNoTxt.Text)+",sutun="+Convert.ToInt32(sutunTxt.Text)+",Kategori='"+kategoriTxt.Text.ToLower()+"' where kitapid="+Convert.ToInt32(kitapNoTxt.Text)+"", baglanti.Baglan());
            cmd.ExecuteNonQuery();
            Kitablo();
            MessageBox.Show("Kitap Güncellendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[seçilenalan].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[seçilenalan].Cells[1].Value.ToString();
            string yayinadi = dataGridView1.Rows[seçilenalan].Cells[2].Value.ToString();
            string sayfasayisi = dataGridView1.Rows[seçilenalan].Cells[3].Value.ToString();
            string ektar = dataGridView1.Rows[seçilenalan].Cells[4].Value.ToString();
            string dil = dataGridView1.Rows[seçilenalan].Cells[5].Value.ToString();
            string yazar = dataGridView1.Rows[seçilenalan].Cells[6].Value.ToString();
            string cevirmen = dataGridView1.Rows[seçilenalan].Cells[7].Value.ToString();
            string editor = dataGridView1.Rows[seçilenalan].Cells[8].Value.ToString();
            string rafno = dataGridView1.Rows[seçilenalan].Cells[9].Value.ToString();
            string sütunno = dataGridView1.Rows[seçilenalan].Cells[10].Value.ToString();
            string kategori = dataGridView1.Rows[seçilenalan].Cells[12].Value.ToString();

            kitapNoTxt.Text = id;
            kitapAdiTxt.Text = ad;
            yayinAdiTxt.Text = yayinadi;
            sayfaSayisi.Text = sayfasayisi;
            dilTxt.Text = dil;
            yazarTxt.Text = yazar;
            cevirmenTxt.Text = cevirmen;
            editorTxt.Text = editor;
            rafNoTxt.Text = rafno;
            sutunTxt.Text = sütunno;
            kategoriTxt.Text = kategori;
        }

    }
}
