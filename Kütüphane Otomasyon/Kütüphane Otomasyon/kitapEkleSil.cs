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
    public partial class kitapEkleSil : Form
    {
        public kitapEkleSil()
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

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into Kitap (kitapid,kitapadi,yayinadi,sayfasayisi,kutupektarihi,dil,yazar,cevirmen,editor,rafno,sutun,kategori,kitapdurum)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p13,@p14)", baglanti.Baglan());
                cmd.Parameters.AddWithValue("@p1", (kitapNoTxt.Text));
                cmd.Parameters.AddWithValue("@p2", (kitapAdiTxt.Text));
                cmd.Parameters.AddWithValue("@p3", (yayinAdiTxt.Text));
                cmd.Parameters.AddWithValue("@p4", (sayfaSayisi.Text));
                cmd.Parameters.AddWithValue("@p5", (ekTarTxt.Value));
                cmd.Parameters.AddWithValue("@p6", (dilTxt.Text));
                cmd.Parameters.AddWithValue("@p7", (yazarTxt.Text));
                cmd.Parameters.AddWithValue("@p8", (cevirmenTxt.Text));
                cmd.Parameters.AddWithValue("@p9", (editorTxt.Text));
                cmd.Parameters.AddWithValue("@p10", (rafNoTxt.Text));
                cmd.Parameters.AddWithValue("@p11", (sutunTxt.Text));
                cmd.Parameters.AddWithValue("@p13", (kategoriTxt.Text));
                cmd.Parameters.AddWithValue("@p14", (0));
                cmd.ExecuteNonQuery();
                MessageBox.Show("kitap eklendi");
                Kitablo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Baglanti baglanti = new Baglanti();
                    MySqlCommand cmd = new MySqlCommand("delete from Kitap where kitapid = @p1", baglanti.Baglan());
                    cmd.Parameters.AddWithValue("@p1", (kitapSilTxt.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarı ile silindi");
                    Kitablo();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void yazarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void dilTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void kitapNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitapSilTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rafNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sutunTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelEkrani fr = new personelEkrani();
            fr.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kitapNoTxt.Clear();
            kitapAdiTxt.Clear();
            yayinAdiTxt.Clear();
            sayfaSayisi.Clear();
            yazarTxt.Clear();
            cevirmenTxt.Clear();
            editorTxt.Clear();
            rafNoTxt.Clear();
            sutunTxt.Clear();
            kategoriTxt.Clear();
            kitapSilTxt.Clear();
            dilTxt.ResetText();
        }

        private void kitapEkleSil_Load(object sender, EventArgs e)
        {
            Kitablo();
        }
    }
}
