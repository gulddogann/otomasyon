namespace Kütüphane_Otomasyonu__bu_son_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
               
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
            button3.PerformClick();
        }
    }
}