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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            Baglanti baglanti = new Baglanti();
            MySqlCommand command = new MySqlCommand("select kitapid,kitapadi,yayinadi,sayfasayisi from Kitap order by kutupektarihi desc",baglanti.Baglan());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            MySqlCommand sqlCommand = new MySqlCommand("select * from Kitap where kitapdurum=1",baglanti.Baglan());
            adapter = new MySqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

            MySqlCommand mySql = new MySqlCommand("SELECT kitapid,kitapadi,sayfasayisi,kitapdurum from Kitap WHERE sayfasayisi=(SELECT MAX(sayfasayisi) FROM Kitap)", baglanti.Baglan());
            adapter = new MySqlDataAdapter(mySql);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView3.DataSource = data.Tables[0];

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Ogrenci.ograd,Ogrenci.ogrsoyad,Ogrenci.ogrbolumad,OgrenciKitap.kitapid,Kitap.kitapadi,OgrenciKitap.verilentarih,OgrenciKitap.alinantarih FROM OgrenciKitap INNER JOIN Ogrenci on Ogrenci.ogrid = OgrenciKitap.ogrid INNER JOIN Kitap on OgrenciKitap.kitapid=Kitap.kitapid WHERE Kitap.sayfasayisi=(SELECT MAX(Kitap.sayfasayisi) from Kitap)", baglanti.Baglan());
            adapter = new MySqlDataAdapter(mySqlCommand);
            DataSet set = new DataSet();
            adapter.Fill(set);
            dataGridView4.DataSource = set.Tables[0];

            MySqlCommand cmd = new MySqlCommand("select * from Ogrenci", baglanti.Baglan());
            adapter = new MySqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            adapter.Fill(dts);
            dataGridView5.DataSource = dts.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelEkrani ekran = new personelEkrani();
            ekran.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
