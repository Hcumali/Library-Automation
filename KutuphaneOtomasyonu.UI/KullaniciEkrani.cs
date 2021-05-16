using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL katmanındaki sınıflara erişim için
using KutuphaneOtomasyonu.Entity; // Entity katmanındaki sınıflara erişim için

namespace KutuphaneOtomasyonu
{
    public partial class KullaniciEkrani : Form
    {
        OgrenciBLL ogrenciBLL; // OgrenciBLL sınıfından nesne tanımlama
        public SecimEkrani secimEkrani; // SecimEkrani formundan yeni form tanımlama
        public string Tc; // Tc isimli string değişken tanımlama

        public KullaniciEkrani(SecimEkrani secimEkrani,string Tc)
        {
            InitializeComponent();

            // Gelen parametreleri tanımladığımız objelere atamak
            this.secimEkrani = secimEkrani;
            this.Tc = Tc;

            ogrenciBLL = new OgrenciBLL(); // OgrenciBLL sınıfından nesne türetmek
        }

        private void Btn_Kullanici_Anasayfa_Click(object sender, EventArgs e) // Çıkış Butonu
        {
            // Bu formu kapat
            this.Close();
        }

        public void listele() // Listele metodu
        {
            // ogrenciBLL sınıfındaki GetAllStudents metodundan dönen bilgileri DataGridView'imizin dataSourcesine atadık.
            dataGridView_KullaniciListesi.DataSource = ogrenciBLL.GetAllStudents();
        }

        private void KullaniciEkrani_Load(object sender, EventArgs e) // Form yüklenir iken yapılacak işlemler
        {
            // Cancel butonunu tanımla
            this.CancelButton = Btn_Kullanici_Anasayfa;
            // listele metodunu çağır.
            listele();
        }

        // DataGridView'in herhangi bir hücresine tıklanınca yapılacaklar
        private void dataGridView_KullaniciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tcno'yu readOnly yap.
            textBox_Tcno.ReadOnly = true;
            // Tıklanan hücrenin sahip olduğu satırdaki bilgileri tek tek textboxlara ata.
            textBox_Tcno.Text = dataGridView_KullaniciListesi.CurrentRow.Cells["Tcno"].Value.ToString();
            textBox_Ad.Text = dataGridView_KullaniciListesi.CurrentRow.Cells["Ad"].Value.ToString();
            textBox_Soyad.Text = dataGridView_KullaniciListesi.CurrentRow.Cells["Soyad"].Value.ToString();
            textBox_Telno.Text = dataGridView_KullaniciListesi.CurrentRow.Cells["Telno"].Value.ToString();
            textBox_Meslek.Text = dataGridView_KullaniciListesi.CurrentRow.Cells["Meslek"].Value.ToString();
        }

        private void Btn_Ogrenci_Guncelle_Click(object sender, EventArgs e) // Öğrenci bilgilerini güncelleme butonu
        {
            if (textBox_Tcno.Text == "") // Tcno boş ise, herhangi bir satır seçilmemiş ise
            {
                // Uyarı mesajı ver.
                MessageBox.Show("Güncellenmek üzere tablodan bir kayıt seçmelisiniz !", "Uyarı");
            }
            else // Herhangi bir problem yok ise
            {
                // Öğrenci modelinden bir nesne türet
                Ogrenci ogrenci = new Ogrenci();
                // Textboxlardaki bilgiler ile içini doldur.
                ogrenci.Tcno = textBox_Tcno.Text;
                ogrenci.Ad = textBox_Ad.Text;
                ogrenci.Soyad = textBox_Soyad.Text;
                ogrenci.Telno = textBox_Telno.Text;
                ogrenci.Meslek = textBox_Meslek.Text;

                // ÖğrenciBLL sınıfından UpdateStudent metoduna oluşturduğumuz ogrenci nesnesini gönder.
                ogrenciBLL.UpdateStudent(ogrenci);
                // Tablonun güncel olması için tekrardan listele() metodu
                listele();

                if (ogrenci.Tcno != Tc) // Farklı bir öğrencinin bilgileri güncellendi ise
                {
                    // Textboxları temizle ve uyarı mesajı ver.
                    textBox_Tcno.Text = "";
                    textBox_Ad.Text = "";
                    textBox_Soyad.Text = "";
                    textBox_Telno.Text = "";
                    textBox_Meslek.Text = "";
                    MessageBox.Show("Kayıt Güncellendi !", "Kayıt");
                }
                else // Kendi bilgilerimizi güncellediysek
                {
                    // Uyarı mesajı ver ve programı kapat.
                    MessageBox.Show("Kayıt Güncellendi. Kendi hesabınızı güncellediğiniz için lütfen tekrar giriş yapınız !", "Kayıt");
                    Application.Exit();
                }
            }
        }

        private void Btn_Ogrenci_Sil_Click(object sender, EventArgs e) // Öğrenci bilgilerini silme butonu
        {
            if (textBox_Tcno.Text == "") // Textbox boş ise ilerleme
            {
                MessageBox.Show("Silinmek üzere tablodan bir kayıt seçmelisiniz !", "Uyarı");
            }
            else // Değil ise
            {
                // Ogrenci modelinden yeni nesne türet.
                Ogrenci silinecekOgrenci = new Ogrenci();
                // Modelin tcno'suna datagridView'deki tc yi bul ve ata.
                silinecekOgrenci.Tcno = dataGridView_KullaniciListesi.CurrentRow.Cells["Tcno"].Value.ToString();

                // ogrenciBLL sınıfından DeleteStudent metodunu çağır ve oluşturduğumuz silinecekOgrenci nesnesini parametre olarak yolla.
                ogrenciBLL.DeleteStudent(silinecekOgrenci);
                // Tablonun güncel olması için tekrardan listeliyoruz
                listele();

                if (silinecekOgrenci.Tcno != Tc) // Kendi kayıdımızı silmedi isek
                {
                    // Textboxları temizle ve uyarı mesajı bas
                    textBox_Tcno.Text = "";
                    textBox_Ad.Text = "";
                    textBox_Soyad.Text = "";
                    textBox_Telno.Text = "";
                    textBox_Meslek.Text = "";
                    MessageBox.Show("Kayıt Silindi !", "Kayıt");
                }
                else // Kendi kayıdımızı sildiysek
                {
                    // Uyarı mesajı ver ve programı kapat.
                    MessageBox.Show("Kayıt silindi. Kendi hesabınızı sildiğiniz için program kapanıyor !", "Kayıt");
                    Application.Exit();
                }
            }
        }

        private void KullaniciEkrani_FormClosed(object sender, FormClosedEventArgs e) // Form kapanır iken yapılacaklar
        {
            // secimEkrani (üst form)'u göster.
            secimEkrani.Show();
        }
    }
}
