## Kütüphane Otomasyonu

# Proje Tanımı ve Amacımız:
Söz konusu Kütüphane Otomasyonu Projesi GT2MTE ekibi tarafından tasarlanacak olup, Uludağ Üniversitesi İnegöl Fakültesi ve İnegöl Meslek Yüksek Okulu Kütüphanelerinde Genel-Geçer işlevleri ve bu işlevlerinde ötesinde bir çok işlevi yerine getirebilecek seviyede bir proje olacaktır.
Kütüphane Genel-Geçer işlevleri aşağıda tanımlanmıştır;


- Kullanıcı kaydı
- Kullanıcı tarafına Kitap emanet verme
- Kullanıcı tarafından Kitap alma
- Personel tarafından Kitap eklenmesi
- Personel tarafından yasaklı yayınların kaldırılması


Bu tür işlevler Geleneksel Kütüphanelerde Kullanıcı ve Personel arasında sağlanıyor olup söz konusu işlevlerin tamamlanması sıra oluşması, gerekli verilerin hatalı girilmesi gibi bir çok dezavantaja sahiptir, bu dezavantajların günümüzde ne kadar hatalı ve tehlikeli olduğu COVID-19 virüs salgınıyla daha da belli olmuştur.
GT2MTE ekibi tarafından tasarlanan Kütüphane Otomasyonu Projesi ile Yeni Nesil Kütüphane Yönetimi sağlanacaktır


Genel-Geçer işlevlerin Ötesi işlevler aşağıda tanımlanmıştır;

- Personel tarafından Kitapların konumuna göre aranması
- Personel tarafından Kitapların Kategoriye göre aranması
- Personel tarafından yasaklı yayınların kısa sürede kaldırılması
- Personel tarafından çeşitli Raporların incelenmesi
- Personel tarafından, emanet altında olan ancak teslim edilmeyen kitapların teslim alınması


Bu tür işlevler ile Otomasyon programı daha etkili ve faydalı çalışacak ve Personel ile Öğrencinin Kütüphane işlerini kolaylaştıracaktır


**NOT:** Kütüphane Kullanıcıları genellikle Öğrencilerden oluştuğundan Proje Öğrenciye yönelik oluşturulmaktadır ancak Akademisyenlerin ve diğer Personellerinde Kütüphaneyi kullanabileceklerinden Uygulamanın ve kullanılacak veri tablolarının kapsamı genişletilebilir olmalıdır, GT2MTE ekibi olarak uygulamamızı ölçeklendirilebilir/Kapsamı genişletilebilir yapmaya özen göstereceğiz ancak önceliğimiz bizden beklenen yani Öğrenciye Yönelik Kütüphane Otomasyonu Projesini geliştirmek olacaktır, Akademisyen ve Personele Yönelik Kütüphane Otomasyonu Projesi bizden beklenen projeye yani Öğrenciye Yönelik Kütüphane Otomasyonuna sonradan entegre edilecektir.

## Proje Gereksinimleri ve Proje sürecinde kullanılacak Yazılım/Donanımlar;


Bu proje sürecinde **Windows 10** ve **Windows 11** türü İşletim Sistemleri kullanılacak olup, **Visual Studio Code**, **Visual Studio Community**, **PhpMyAdmin**, **Github Desktop** ve **Github.com** Yazılımları kullanılacaktır.

Söz konusu Yazılımlarda ise **C# programlama dili** ve **MySql veri sorgulama dili** kullanılacaktır.
Kodlar, Github Desktop programı ile Github.com a push edilerek gönderilecektir
Proje süreci Github.com dan sağlanacak olup, süreç 4 kişi arasında görev dağılımı ile paylaşılacaktır.

PhpMyAdmin Veritabanı Yönetim Yazılımı üzerinde yazılacak MySQL veri sorgulama dili ile aşağıdaki veritabanı ve veritabanları tanımlanacaktır.

**Veri Tabanı Adı**
- GT2MTE

**Tablolar**
- Personel
- Üye
- ÜyeKitap(Emanet tablosu)
- Kitap

**Üye Tablo ile Kütüphane ana kullanıcılarının yani Üyelerin**
-	Üye ID
-	Üye Ad
-	Üye Soyad
-	Üye Telefon numarası
-	Üye e-postası
-	Öğrenci Bölüm bilgisi
-	Meslek

**Kitap Tablo ile Kitapların**
-	Kitap ISBN
-	Kitap Ad
-	Kitap Yayınevi
-	Kitap dili
-	Kitap Yazarı
-	Kitap Çevirmeni
-	Kitap Editörü
-	Kitap Sayfa Sayısı
-	Kitap rafno
-	Kitap sütunno
-	Kitap Kategori
-	Emanet durumu
-	Kütüphaneye eklenme tarihi

**Personel Tablo ile Personellerin**
- Personel ID
- Personel Ad
- Personel Soyad
- Personel telno
- Personel Eposta
- Personel Şifre

**ÖğrenciKitap Tablosu ile Emanet verilen Kitapların**
- ISBN
- Üye ID
- Verilen tarih
- Alınan Tarih

Bilgileri tutulmuştur

## Form Tasarımı
Her işlev için Form Ekranı tasarlanmış olup Arka Plan rengi DarkSlate Gray rengi iken işlevler için tasarlanmış Groupboxların arka plan rengi ColorLightLight dır.
GroupBox lardaki labeller için renk ColorText olup Form Ekranı labelleri için renk Orange(Turuncu) rengidir ve her Formda Uludağ Üniversitesi resmi logosu kullanılmıştır

## Ekran Görüntüleri

**Giriş Ekranı**

![Giriş Ekranı](https://user-images.githubusercontent.com/102298378/172700324-d21117db-3f0d-41c8-b8fb-c4d5ad965559.jpeg)

Personel giriş yapar eğer kayıtlı değilse kayıt ol ekranına gider.Şifresini unuttuysa şifremi unuttum ekranına gider.

**Personel Kayıt Ekranı**

![personel kayıt ekranı](https://user-images.githubusercontent.com/102298378/172700639-f4f2bbb1-154a-4925-b331-5819b813a5d1.jpeg)

Personel kaydı yapılır eğer yanlışlıkla bu butona bastıysa iptal butonuyla giriş ekranına döner.

**Şifremi Unuttum Ekranı**

![şifremi unuttum ekranı](https://user-images.githubusercontent.com/102298378/172701447-981afbcf-67f4-466f-9d8c-fb729e4cb787.jpeg)

Personel şifresini unuttuysa bilgilerini doldurup yeni şifre belirler.

**Ana Ekran**

![personel ana ekran](https://user-images.githubusercontent.com/102298378/172705444-769a507b-b9a6-4c88-9bdd-cd5afd5195c8.png)

Personel yapabileceği bütün fonksiyonları bu ekranda görür ve istediği ekrana geçiş yapabilir.Ayrıca kayıtlı bilgileri görür.

**Üye Kayıt-Sil Ekranı**

![üye kayıt ve sil](https://user-images.githubusercontent.com/102298378/172701960-4a99e0d6-6422-435c-b277-174b8cc0a32e.jpeg)

Üye bilgileri doldularak kayıt edilir.Kaydını sildirmek isteyen veya silinmesi gereken üyelerin kaydı silinir.

**Kitap Alış-Veriş Ekranı**

![kitap alış-veriş ekranı](https://user-images.githubusercontent.com/102298378/172702540-85bf16b9-7c65-4979-a917-5733293928ee.jpeg)

Gerekli bilgiler doldurularak belirlenen sürede kitap emanet verilir ve belirlen sürede teslim alınır.Teslim tarihi gecikmiş kitapların bilgisi geç kalmış kitaplar panelinde görünür. 

**Kitap Ekle-Sil Ekranı**

![kitap ekle sil](https://user-images.githubusercontent.com/102298378/172702998-d0905941-7a97-411b-b6b6-9ef3a1853bb0.jpeg)

Kitap bilgileri girilerek kitap eklenir.Eklenen kitaplar ekranda görünür.Kitap bilgileri girilerek kitap silme panelinde kaydı silinir.

**Arama Ekranı**

![arama ekranı](https://user-images.githubusercontent.com/102298378/172703306-d7140d54-c246-4a78-9918-30cf7ad0c46c.jpeg)

Gerekli bilgilere ulaşmak için aranan özellikler girilir ve panelde görülür. 

**Kitap Güncelleme Ekranı**

![kitap güncelleme](https://user-images.githubusercontent.com/102298378/172703563-aa247869-88d7-47c8-a60f-59a3c39cf7c9.jpeg)

Kitap bilgileri girilerek eksik veya yanlış bilgiler düzeltilir.

**Rapor-İstatistik Ekranı**

![rapor ekranı](https://user-images.githubusercontent.com/102298378/172703747-d3e64cba-ae89-492e-a950-e956a044730b.jpeg)

Rapor ve İstatistik ekranında son eklenen kitaplar,en çok kitap okuyan öğrenci,emanet altındaki kitaplar,en fazla sayfası olan kitaplar ve üyeler görünür.



