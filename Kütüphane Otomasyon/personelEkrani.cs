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
    public partial class personelEkrani : Form
    {
        public personelEkrani()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kitapEkleSil fr=new kitapEkleSil();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrKayıtSil fr=new ogrKayıtSil();
            fr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ogrKayıtSil fr = new ogrKayıtSil();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            persKitapAra fr = new persKitapAra();
            fr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            personelGiris fr = new personelGiris();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kitapEmanet fr= new kitapEmanet();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapAlVer fr = new kitapAlVer();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
            this.Hide();
        }
        Baglanti baglanti = new Baglanti();
        private void personelEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("select personelad as Adi,personelsoyad as Soyadi,personeltelno as Telefon,personeleposta as Eposta from Personel", baglanti.Baglan());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                MySqlCommand cmd = new MySqlCommand("select ogrid as ID,ograd as Ad,ogrsoyad as Soyad,ogrtel as Telefon,ogrposta as Eposta,meslek as Meslek,ogrbolumad as OgrBolum from Ogrenci",baglanti.Baglan());
                adapter = new MySqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];

                MySqlCommand cmd1 = new MySqlCommand("select * from Kitap",baglanti.Baglan());
                adapter = new MySqlDataAdapter(cmd1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView3.DataSource = dataSet.Tables[0];

                MySqlCommand cmd2 = new MySqlCommand("select * from Kitap inner join OgrenciKitap on Kitap.kitapid=OgrenciKitap.kitapid where Kitap.kitapdurum=1", baglanti.Baglan());
                adapter = new MySqlDataAdapter(cmd2);
                DataSet dts = new DataSet();
                adapter.Fill(dts);
                dataGridView4.DataSource = dts.Tables[0];

            }
            catch (System.TimeoutException)
            {
                MessageBox.Show("Okulun internetine bağlı olduğunuzdan emin olun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
