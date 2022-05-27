using MySql.Data.MySqlClient;

namespace Kütüphane_Otomasyonu__bu_son_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0,0);
        }

        private void kitapekle_Click(object sender, EventArgs e)
        {
            Kitap_ekle kitap_Ekle = new Kitap_ekle();
            kitap_Ekle.Show();
        }

        private void kitapsil_Click(object sender, EventArgs e)
        {
            Kitap_Sil kitap_Sil = new Kitap_Sil();
            kitap_Sil.Show();
        }

        private void kitapkontrol_Click(object sender, EventArgs e)
        {
            Kitap_Kontrol kitap_Kontrol = new Kitap_Kontrol();
            kitap_Kontrol.Show();
        }

        private void kayıtol_Click(object sender, EventArgs e)
        {
            Personel_Kayıt Personel_kayıt = new Personel_Kayıt();
            Personel_kayıt.Show();
        }

        private void ogrkayıt_Click(object sender, EventArgs e)
        {
            Ogrenci_Kayıt ogrenci_Kayıt = new Ogrenci_Kayıt();
            ogrenci_Kayıt.Show();
        }

        private void kitapver_Click(object sender, EventArgs e)
        {
            Kitap_Ver kitap_Ver = new Kitap_Ver();
            kitap_Ver.Show();
        }

        private void kitapal_Click(object sender, EventArgs e)
        {
            Kitap_AlisVeris kitap_Al = new Kitap_AlisVeris();
            kitap_Al.Show();
        }

        MySqlConnection conn = new MySqlConnection("SERVER=172.21.54.3;DATABASE=GT2MTE;UID=GT2MTE;PWD=G9m5m1t2e357.");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("select * from Personel where perid=@p1 and PersonelSifre=@p2",conn);
            mySqlCommand.Parameters.AddWithValue("@p1",textBox1.Text);
            mySqlCommand.Parameters.AddWithValue("@p2",textBox3.Text);
            MySqlDataReader dr = mySqlCommand.ExecuteReader();
            if (dr.Read())
            {
                kitapekle.Enabled = true;
                ogrkayıt.Enabled = true;
                kitapkontrol.Enabled = true;
                kitapal.Enabled = true;
                button2.Enabled = true;
                kayıtol.Enabled = true;
                button3.Enabled = true;

                MessageBox.Show("Giriş Yapıldı!");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap_Ara kitap_Ara = new Kitap_Ara();
            kitap_Ara.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Öğrenci_Sil öğrenci_Sil = new Öğrenci_Sil();
            öğrenci_Sil.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapekle.Enabled = false;
            ogrkayıt.Enabled = false;
            kitapkontrol.Enabled = false;
            kitapal.Enabled = false;
            button2.Enabled = false;
            kayıtol.Enabled = true;
            button3.Enabled = false;
        }
    }
}