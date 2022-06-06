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
    public partial class persKitapAra : Form
    {
        public persKitapAra()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();

        private void kitapNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void persKitapAra_Load(object sender, EventArgs e)
        {
            //MySqlCommand cmd1 = new MySqlCommand("select * from Kitap", baglanti.Baglan());
            //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet);
            //dataGridView2.DataSource = dataSet.Tables[0];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personelEkrani fr = new personelEkrani();
            fr.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand command;
            try
            {
                if (textBox1.Text == "")
                {
                    command = new MySqlCommand("select * from " + tabloadi + " ", baglanti.Baglan());
                }
                else
                {
                    command = new MySqlCommand("select * from " + tabloadi + " where " + sütunadi + " like '%" + textBox1.Text + "%'", baglanti.Baglan());
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Önce Neyle ilgili arama yapacağınız seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kitapNoTxt_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand command;
            try
            {
                if (kitapNoTxt.Text == "")
                {
                    command = new MySqlCommand("select * from " + tabloadi + " ", baglanti.Baglan());
                }
                else
                {
                    command = new MySqlCommand("select * from " + tabloadi + " where " + sütunid + " like '%" + Convert.ToInt32(kitapNoTxt.Text) + "%'", baglanti.Baglan());
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Önce Neyle ilgili arama yapacağınız seçin!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        string tabloadi = "";
        string sütunadi = "";
        string sütunid = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    tabloadi = "Ogrenci";
                    sütunadi = "ograd";
                    sütunid = "ogrid";
                    label8.Visible = true;
                    comboBox2.Visible = true;
                    label1.Text = "Üye ID";
                    label7.Text = "Üye Ad";
                    label8.Text = "Üye Meslek";
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Öğrenci");
                    comboBox2.Items.Add("Akademisyen");
                    comboBox2.Items.Add("Personel");
                    MySqlCommand command;
                    command = new MySqlCommand("select * from " + tabloadi + " ", baglanti.Baglan());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    break;
                case 1:
                    tabloadi = "Personel";
                    sütunadi = "personelad";
                    sütunid = "perid";
                    
                    label1.Text = "Personel ID";
                    label7.Text = "Personel Ad";
                    label8.Visible = false;
                    comboBox2.Visible = false;
                    command = new MySqlCommand("select perid as ID,personelad as PersonelAd,personelsoyad as PersonelSoyad,personeltelno as Telefon,personeleposta as Eposta from " + tabloadi + " ", baglanti.Baglan());
                    adapter = new MySqlDataAdapter(command);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    break;
                case 2:
                    tabloadi = "Kitap";
                    sütunadi = "kitapadi";
                    sütunid = "kitapid";

                    label1.Text = "ISBN";
                    label7.Text = "Kitap Ad";
                    label8.Visible = true;
                    comboBox2.Visible = true;
                    label8.Text = "Kitap Kategori";
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("deneme");
                    comboBox2.Items.Add("makale");
                    comboBox2.Items.Add("korku");
                    command = new MySqlCommand("select * from " + tabloadi + " ", baglanti.Baglan());
                    adapter = new MySqlDataAdapter(command);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    break;
                case 3:
                    tabloadi = "OgrenciKitap";
                    sütunadi = "kitapid";
                    sütunid = "ogrid";

                    label1.Text = "Üye ID";
                    label7.Text = "ISBN";
                    label8.Visible = false;
                    comboBox2.Visible = false;
                    command = new MySqlCommand("select OgrenciKitap.ogrid as UyeID,OgrenciKitap.kitapid as ISBN,OgrenciKitap.verilentarih,OgrenciKitap.alinantarih,Kitap.kitapdurum from " + tabloadi + " inner join Kitap on Kitap.kitapid=OgrenciKitap.kitapid", baglanti.Baglan());
                    adapter = new MySqlDataAdapter(command);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    break;
            }
        }
    }
}
