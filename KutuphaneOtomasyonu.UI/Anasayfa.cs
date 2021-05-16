using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL;    // BLL Katmanına Erişim için yazılan kod
using KutuphaneOtomasyonu.Entity; // Entity Katmanına Erişim için yazılan kod

namespace KutuphaneOtomasyonu
{
    public partial class Anasayfa : Form
    {
        OgrenciBLL ogrenciBLL;  // ÖğrenciBLL Sınıfından nesne tanımlanıyor.
        public string activeStudenTC = "";  
        // activeStudenTC isimli string bir değişken oluşturuluyor.Giriş yaptıktan sonra öğrenci tc sinin diğer formlara taşınabilmesi için önemlidir.

        public Anasayfa()  // Constructor
        {
            InitializeComponent();
            ogrenciBLL = new OgrenciBLL();  // ÖğrenciBLL Sınıfından nesne oluşturuluyor.
        }

        private void Anasayfa_Load(object sender, EventArgs e) // Anasayfa yüklenirken yapılacaklar
        {
            // Cancel ve accept butonları tanımlanıyor.Yani esc veya enter'e basıldıgında hangi buton çalışsın.
            this.CancelButton = Btn_cikis;
            this.AcceptButton = Btn_giris;
        }

        private void Btn_cikis_Click(object sender, EventArgs e)
        {
            // DialogResult Sınıfından nesne oluşturuyorum.Ve ekrana messagebox basıyorum.Kullanıcı yes butonuna tıklarsa program çalışmayı bitirsin.
            DialogResult LogOut;
            LogOut = MessageBox.Show("ÇIKIŞ YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (LogOut == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_kayit_Click(object sender, EventArgs e) // Öğrenci(Kullanıcı) Kayıt Butonu
        {
            // Öğrenci modelinden bir nesne oluşturuluyor ve textboxlardaki bilgiler bu oluşan nesnesin özelliklerini dolduruyor.
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Tcno = textBox_tcno.Text;
            ogrenci.Ad = textBox_ad.Text;
            ogrenci.Soyad = textBox_soyad.Text;
            ogrenci.Telno = textBox_telno.Text;
            ogrenci.Meslek = textBox_meslek.Text;
            ogrenci.Kayit_Tarihi = DateTime.Now;

            if(textBox_tcno.TextLength != 11)   // TC, 11 haneli değil ise devam etme .
            {
                // Uyarı mesajı bas.
                MessageBox.Show("TC Kimlik numaranız 11 haneli olmalıdır.", "Hata");
            }
            else  // TC, 11 haneli ise içeri gir
            {
                // Textboxlardaki alanlardan herhangi biri 3 karakterden kısa ise içeri girme.
                if(textBox_ad.TextLength < 3 || textBox_soyad.TextLength < 3 || textBox_telno.TextLength < 9 || textBox_meslek.TextLength < 3)
                {
                    // Uyarı mesajı bas.
                    MessageBox.Show("Belirlenen sayının altında karakter girilemez!", "Hata");
                }
                else  // Herhangi bir sıkıntı yok ise ->
                {
                    // ÖğrenciBLL katmanındaki AddStudent fonksiyonuna(Öğrenciyi kayıt etmeye sağlayan fonksiyon) oluşturdugumuz ogrenci nesnesini yolla.
                    ogrenciBLL.AddStudent(ogrenci);
                    // Textboxların içi temizleniyor.
                    textBox_tcno.Text = "";
                    textBox_ad.Text = "";
                    textBox_soyad.Text = "";
                    textBox_telno.Text = "";
                    textBox_meslek.Text = "";
                    // Ekrana bilgi mesajı bas.
                    MessageBox.Show("Kayıt Başarılı ! Giriş Yapabilirsiniz..", "Kayıt");
                }
            }
        }

        private void Btn_giris_Click(object sender, EventArgs e)  // Otomasyona giriş fonksiyonudur.Giriş butonuna basıldığı anda tetiklenir.
        {
            Boolean sonuc;// sonuc adında boolean bir değişken oluşturduk.

            // Textboxdaki veriyi tc isimli değişkene aktardık.
            string Tc = textBox_giris_tcno.Text;
            // ÖğrenciBLL katmanındaki isThereStudent fonksiyonuna gelen tc yi yollayarak databasemizde böyle bir öğrenci var mı yok mu diye kontrol ediyoruz.
            //Dönen değer 1 yada 0 dır.
            sonuc = ogrenciBLL.isThereStudent(Tc);
            // Giriş başarılı ise tc  yi diğer formlarda da kullanabilmemiz için activeStudenTc ye aktarıyoruz
            activeStudenTC = Tc;
            
            if (textBox_giris_tcno.TextLength != 11)  // 11 haneden farklı ise devam etme
            {
                textBox_giris_tcno.Text = "";
                MessageBox.Show("TC Kimlik numaranız 11 haneli olmalıdır.", "Hata");
            }
            else // 11 hane ise
            {
                if (sonuc) // sonuc değişkeninde 1 değeri var ise giriş başarılı
                {
                    // Bilgilendirme mesajı bas
                    MessageBox.Show("Giriş Başarılı ! Seçim Ekranına Yönlendiriliyorsunuz..", "Giriş");
                    // Seçim ekranı formundan bir form yarat ve activeStudentTc'yi parametre olarak yolla. 
                    SecimEkrani SecimEkrani = new SecimEkrani(activeStudenTC);
                    // Ve bu formu göster
                    SecimEkrani.Show();

                    // Bu formu gizle.
                    this.Hide();
                }
                else // 0 değeri var ise textbox temizle ve ekrana uyarı mesajı bas.
                {
                    textBox_giris_tcno.Text = "";
                    MessageBox.Show("Girdiğiniz bilgiye sahip bir kullanıcı bulunamadı !", "Giriş");
                }
            }

        }


        private void textBox_giris_tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bu fonksiyonun amacı Tcno-Giriş textboxına sayı haricinde karakter girişini engellemektir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
