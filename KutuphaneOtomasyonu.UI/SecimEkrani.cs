using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL Katmanındaki sınıflara erişim için

namespace KutuphaneOtomasyonu
{
    public partial class SecimEkrani : Form
    {
        OgrenciBLL ogrenciBLL; // OgrenciBLL sınıfından nesne tanımlama
        KitapTakibiBLL kitapTakibiBLL; // KitapTakibiBLL sınıfından nesne tanımlama
        public string activeStudentTC; // activeStudentTC isimli bir string tanımlama

        public SecimEkrani(string activeStudentTC) // String bir parametre almış Constructor
        {
            InitializeComponent();

            // OgrenciBLL ve KitapTakibiBLL sınıflarından nesne türetiyoruz.
            ogrenciBLL = new OgrenciBLL();
            kitapTakibiBLL = new KitapTakibiBLL();

            // Gelen parametreyi oluşturduğum stringe atıyorum
            this.activeStudentTC = activeStudentTC;
        }

        private void Btn_SecimEkrani_cikis_Click(object sender, EventArgs e) // Programdan Çıkış Butonu
        {
            // DialogResult sınıfından bir nesne ürettik ve ekrana bir messagebox basıyoruz.Gelen input "yes" ise programdan çıkış yap.
            DialogResult LogOut;
            LogOut = MessageBox.Show("ÇIKIŞ YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (LogOut == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Kitap_Click(object sender, EventArgs e) // Kitap İşlemlerine Gidiş Butonu
        {
            // KitapEkrani formundan yeni bir form oluştur.
            KitapEkrani kitap_secim_ekrani = new KitapEkrani(this, activeStudentTC, label_ogrenci_borc);
            // kitap_secim_ekrani formunu göster
            kitap_secim_ekrani.Show();
            // Bu formu gizle
            this.Hide();
        }

        private void Btn_Ogrenci_Click(object sender, EventArgs e) // Öğrenci İşlemlerine Gidiş Butonu
        {
            // KullaniciEkrani formundan yeni bir form oluştur.
            KullaniciEkrani kullanici_ekrani = new KullaniciEkrani(this, activeStudentTC);
            // kullanici_ekrani formunu göster
            kullanici_ekrani.Show();
            // Bu formu gizle
            this.Hide();
        }

        public void BorcGoster() // Öğrencinin kitaplardan dolayı kaynaklanan herhagi bir borcu var ise bu fonksiyonda açığa çıkartılır.
        {
            int CezaTutari = 0; // CezaTutari adında int değişken tanımladım.
            // dataGridView_borc2'ye giriş yapan öğrencinin aldığı kitapları listeledim. Not: Formda gözükmez ama işlemler için gerekli
            dataGridView_borc.DataSource = kitapTakibiBLL.GetBookHistoryFromStudenTC(activeStudentTC); // datagrid'i doldur // LİSTELE

            // DataGridView'in her satırını gez
            foreach (DataGridViewRow row in dataGridView_borc.Rows) // satırları kullanıcının kitap durumuna göre boyama işlemi
            {
                // Satırın sıfırıncı hücresinin değeri null'dan farkli ise bloğa gir.
                if (row.Cells[0].Value != null)
                {
                    // Kitabın teslim tarihinden bugünün tarihini çıkart.Tarihsel düzeyde aritmatik işlem!
                    DateTime d1 = DateTime.Now;
                    DateTime d2 = Convert.ToDateTime(row.Cells[5].Value);
                    var result = d2.Subtract(d1);

                    // Herhangi bir kitabın teslim tarihi geçmiş ise
                    if (row.Cells[6].Value.ToString() == "" && result.TotalDays < 0) // Herhangi bir kitabın teslim tarihi geçmiş ise
                    {
                        int Day = Convert.ToInt32(result.TotalDays) * -1;
                        CezaTutari += Day * 1; // Kitabı teslim etmediği her gün için 1 tl
                    }
                }
            } // end of the foreach

            // Ceza tutarının durumuna göre label'e text ata.
            if (CezaTutari == 0)
            {
                label_ogrenci_borc.Text = "Herhangi bir borcunuz bulunmamaktadır.";
            }
            else
            {
                label_ogrenci_borc.Text = "Toplam " + CezaTutari + " TL Borcunuz bulunmaktadır.";
            }
        }

        private void SecimEkrani_Load(object sender, EventArgs e) // Form yüklenir iken yapılacak işlemler
        {
            // Cancel buttonunu ata.
            this.CancelButton = Btn_SecimEkrani_cikis;
            // Giriş yapan öğrencinin ismini ogrenciBLL sınıfından getName fonksiyonu aracılığıyla al.
            string isim = ogrenciBLL.getName(activeStudentTC);
            // Gelen ismi büyük harfli versiyonuna çevir.
            isim = isim.ToUpper();
            // Hoşgeldin metnini ekrana bas.
            label_welcome_username.Text = "Hoşgeldin " + isim;

            BorcGoster(); // Kullanıcının borcu olup olmadıgını belirten fonksiyon.Borcu var ise tutarı da gözükür.

        }

    } 
}
