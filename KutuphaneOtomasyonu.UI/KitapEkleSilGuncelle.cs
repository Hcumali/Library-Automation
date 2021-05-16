using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL Katmanına erişim için gerekli
using KutuphaneOtomasyonu.Entity; // Entity Katmanına erişim için gerekli

namespace KutuphaneOtomasyonu
{
    public partial class KitapEkleSilGuncelle : Form
    {
        public KitapEkrani kitapEkrani; // KitapEkrani formundan form tanımladık.
        KitapBLL kitapBLL; // KitapBLL sınıfından nesne tanımladık
        
        public KitapEkleSilGuncelle(KitapEkrani kitapEkrani)
        {
            InitializeComponent();
            // Gelen form parametresini oluşturduğumuz kitap ekranına aktar.
            // Burada yeni form oluşturup eskisini kapatmamamın sebebi; Giriş yapan öğrencinin tc sini her formda aktif bir biçimde kullanabilmektir.
            // Misal fonksiyon yardımıyla tc yi yollayarak öğrencinin adını çekmek
            this.kitapEkrani = kitapEkrani;
            // KitapBLL sınıfından nesne oluşturuyoruz.
            kitapBLL = new KitapBLL();
        }

        private void Btn_KitapIslemlerineDon_Click(object sender, EventArgs e)
        {
            // Çıkış butonu tıklandığında bu formu kapat.
            this.Close();
        }

        private void KitapEkleSilGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapanır iken, bir alt formu göster.
            // Yeni bir form oluşturmadıgımız için parametre ile aktardıgımız tc no kaybolmayacak ve rahatlıkla kullanabilecez.
            kitapEkrani.Show();
        }

        private void KitapEkleSilGuncelle_Load(object sender, EventArgs e)
        {
            // cancel butonunu tanımla. ESC basılınca çalışacak buton.
            this.CancelButton = Btn_KitapIslemlerineDon;
            // Form yüklenir iken listele metodunu çağır.
            listele();
        }

        private void Btn_Kitap_Kaydet_Click(object sender, EventArgs e)  // Kitap Kaydetme butonudur.
        {
            if (textBox_Kitap_Kaydet_Serino.Text == "" || textBox_Kitap_Kaydet_Ad.Text == "" || textBox_Kitap_Kaydet_Tur.Text == "" || textBox_Kitap_Kaydet_SayfaSayi.Text == "" || textBox_Kitap_Kaydet_Yazar.Text == "" || textBox_Kitap_Kaydet_BasimTarihi.Text == "")
            {
                // Herhangi bir alan boş ise if bloğuna gir ve ekrana hata mesajı bas.
                MessageBox.Show("Lütfen tüm alanları doldurunuz !", "Hata");
            }
            else // Alanlar dolu ise
            {
                // Kitap modelinden bir nesne türet ve textboxlardaki bilgilerle nesneyi doldur.
                Kitap kitap = new Kitap();
                kitap.Serino = textBox_Kitap_Kaydet_Serino.Text;
                kitap.Ad = textBox_Kitap_Kaydet_Ad.Text;
                kitap.Tur = textBox_Kitap_Kaydet_Tur.Text;
                kitap.Sayfa_Sayisi = Int32.Parse(textBox_Kitap_Kaydet_SayfaSayi.Text);
                kitap.Yazar = textBox_Kitap_Kaydet_Yazar.Text;
                kitap.BasimTarihi = textBox_Kitap_Kaydet_BasimTarihi.Text;

                if (textBox_Kitap_Kaydet_Serino.TextLength != 7) // Kitap serinosu 7 haneden farklı ise ilerleme
                {
                    MessageBox.Show("Kitap seri numarası 7 haneli olmalıdır.", "Hata");
                }
                else // serino 7 haneli ise
                {
                    if (textBox_Kitap_Kaydet_Ad.TextLength < 3 || textBox_Kitap_Kaydet_Yazar.TextLength < 3 || textBox_Kitap_Kaydet_BasimTarihi.TextLength < 3 || textBox_Kitap_Kaydet_Tur.TextLength < 3)
                    {
                        // Herhangi bir textbox 3 karakterin altında ise ilerleme.
                        MessageBox.Show("Belirlenen sayının altında karakter girilemez!", "Hata");
                    }
                    else // Herhangi bir problem yok ise.
                    {
                        // KitapBLL sınıfından AddBook(Kitap Ekleme) fonksiyonuna içini doldurduğumuz kitap nesnesini yolla.
                        kitapBLL.AddBook(kitap);
                        // Textboxların içini temizle.
                        textBox_Kitap_Kaydet_Serino.Text = "";
                        textBox_Kitap_Kaydet_Ad.Text = "";
                        textBox_Kitap_Kaydet_Tur.Text = "";
                        textBox_Kitap_Kaydet_SayfaSayi.Text = "";
                        textBox_Kitap_Kaydet_Yazar.Text = "";
                        textBox_Kitap_Kaydet_BasimTarihi.Text = "";
                        // Tablonun güncel olması açısından listele() metodunu tekrar çağır.
                        listele();
                        // Ekrana bilgi mesajı bas.
                        MessageBox.Show("Kayıt Başarılı ! Kitap kayıt edildi..", "Kayıt");
                    }
                }
            }
        }

        private void Btn_Kitap_Guncelle_Click(object sender, EventArgs e)
        {
            if (textBox_Kitap_Guncelle_Serino.Text == "") // Serino alanı boş ise ilerleme
            {
                // Tablodan ilgili satıra tıklanarak güncellenecek kitabın seçilmesi gerekli
                MessageBox.Show("Güncellenmek üzere tablodan bir kayıt seçmelisiniz !", "Uyarı");
            }
            else // Herhangi bir sıkıntı yok ise.
            {
                // Kitap modelinden bir nesne oluştur.
                Kitap kitap = new Kitap();
                // Nesnenin içini textboxtaki bilgiler ile doldur.
                kitap.Serino = textBox_Kitap_Guncelle_Serino.Text;
                kitap.Ad = textBox_Kitap_Guncelle_Ad.Text;
                kitap.Tur = textBox_Kitap_Guncelle_Tur.Text;
                kitap.Sayfa_Sayisi = Int32.Parse(textBox_Kitap_Guncelle_SayfaSayi.Text);
                kitap.Yazar = textBox_Kitap_Guncelle_Yazar.Text;
                kitap.BasimTarihi = textBox_Kitap_Guncelle_BasimTarihi.Text;

                // KitapBLL sınıfından UpdateBook yani kitap güncelleme fonksiyonumuza oluşturduğumuz kitap nesnesini yolla.
                kitapBLL.UpdateBook(kitap);

                // Textboxları temizle.
                textBox_Kitap_Guncelle_Serino.Text = "";
                textBox_Kitap_Guncelle_Ad.Text = "";
                textBox_Kitap_Guncelle_Tur.Text = "";
                textBox_Kitap_Guncelle_SayfaSayi.Text = "";
                textBox_Kitap_Guncelle_Yazar.Text = "";
                textBox_Kitap_Guncelle_BasimTarihi.Text = "";

                // Tablo güncelliği için listele() metodu ve ekrana bilgi mesajı.
                listele();
                MessageBox.Show("Kayıt Güncellendi !", "Kayıt");
            }
        }

        private void Btn_Kitap_Sil_Click(object sender, EventArgs e) // Kitap silme butonu
        {
            if (textBox_Kitap_Guncelle_Serino.Text == "") // Tablodan bir kitap seçilmemiş ise yani serino alanı boş ise.
            {
                MessageBox.Show("Silinmek üzere tablodan bir kayıt seçmelisiniz !", "Uyarı");
            }
            else // Kitap seçilmiş ise
            {
                // Kitap sınıfından bir nesne türet.
                Kitap silineceKitap = new Kitap();
                // Silinecek kitabın serinosunu seçilmiş hücrenin ilgili hücresinden çek ve oluşturduğumuz nesnenin serino özelliğine ata.
                silineceKitap.Serino = dataGridView_KitapListesi.CurrentRow.Cells["Serino"].Value.ToString();

                // KitapBLL sınıfından DeleteBook yani kitap silme fonksiyonuna oluşturduğumuz nesneyi silinmek üzere gönder.
                kitapBLL.DeleteBook(silineceKitap);

                // Textboxlarımızın içlerini temizliyoruz.
                textBox_Kitap_Guncelle_Serino.Text = "";
                textBox_Kitap_Guncelle_Ad.Text = "";
                textBox_Kitap_Guncelle_Tur.Text = "";
                textBox_Kitap_Guncelle_SayfaSayi.Text = "";
                textBox_Kitap_Guncelle_Yazar.Text = "";
                textBox_Kitap_Guncelle_BasimTarihi.Text = "";

                // Tablo güncelliği için listele() metodu ve ekrana bilgi mesajı
                listele();
                MessageBox.Show("Kayıt Silindi !", "Kayıt");
            }
        }

        public void listele() // Listele metodu
        {
            // DataGridView imizin içini doldurur.
            // KitapBLL sınıfından GetAllBooks fonksiyonu ile DataGridView imizin içini doldururuz.
            dataGridView_KitapListesi.DataSource = kitapBLL.GetAllBooks();
        }

        private void dataGridView_KitapListesi_CellClick(object sender, DataGridViewCellEventArgs e) // DataGridView'in herhangi bir hücresine tıklanır ise, seçme işlemi
        {
            // Serino alanını readOnly yap yani değiştirelemez olsun.
            textBox_Kitap_Guncelle_Serino.ReadOnly = true;

            // Seçilen satırdaki bilgileri güncelleme alanının altındaki textboxlara ata.
            textBox_Kitap_Guncelle_Serino.Text = dataGridView_KitapListesi.CurrentRow.Cells["Serino"].Value.ToString();
            textBox_Kitap_Guncelle_Ad.Text = dataGridView_KitapListesi.CurrentRow.Cells["Ad"].Value.ToString();
            textBox_Kitap_Guncelle_Tur.Text = dataGridView_KitapListesi.CurrentRow.Cells["Tur"].Value.ToString();
            textBox_Kitap_Guncelle_SayfaSayi.Text = dataGridView_KitapListesi.CurrentRow.Cells["SayfaSayisi"].Value.ToString();
            textBox_Kitap_Guncelle_Yazar.Text = dataGridView_KitapListesi.CurrentRow.Cells["Yazar"].Value.ToString();
            textBox_Kitap_Guncelle_BasimTarihi.Text = dataGridView_KitapListesi.CurrentRow.Cells["BasimTarihi"].Value.ToString();
        }
    }
}
