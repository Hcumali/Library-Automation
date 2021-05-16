using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL Katmanındaki sınıflara erişimi sağlar.

namespace KutuphaneOtomasyonu
{
    public partial class KitapEkrani : Form
    {
        public SecimEkrani secimEkrani; // Seçim ekranı formundan yeni bir form tanımlama
        public string activeStudentTC; // activeStudentTC isimli string oluşturma
        KitapTakibiBLL kitapTakibiBLL; // KitapTakibiBLL sınıfından nesne tanımlama
        Label label_ogrenci_borc; // label_ogrenci_borc isimli label tanımlama

        public KitapEkrani(SecimEkrani secimEkrani, string activeStudentTC, Label label_borc) // Constructor
        {
            // Constructor'umuz 3 adet parametre alıyor.Biri seçim ekranı formu , diğeri giriş yapan öğrencinin tc'si, en sonuncusu ise borç durumu için bir label
            InitializeComponent();

            // Parametredeki veriler üstte oluşturduğumuz nesnelere atanıyor.
            this.secimEkrani = secimEkrani; 
            this.activeStudentTC = activeStudentTC;
            kitapTakibiBLL = new KitapTakibiBLL();
            this.label_ogrenci_borc = label_borc;
        }

        private void KitapEkrani_Load(object sender, EventArgs e) // Form yüklenir iken yapıcaklar
        {
            // Cancel Button tanımlanıyor. ESC ye basılınca tetiklenecek buton
            this.CancelButton = Btn__Kitap_Anasayfa;
            // Bazı butonların texti değiştiriliyor.
            Btn_Kitap_OgrenciKitapProfili.Text = "Öğrenci\n" + "Kitap Profili";
            Btn_ZedGraph.Text = "ZedGraph\n" + "Mevcut Kitapların Grafikleri";
        }


        private void Btn__Kitap_Anasayfa_Click(object sender, EventArgs e) // Formdan çıkış butonu - üst menüye gider.
        {
            this.Close(); // Bu formu kapat
        }

        public void BorcGoster() // Öğrencinin kitaplardan dolayı kaynaklanan herhagi bir borcu var ise bu fonksiyonda açığa çıkartılır.
        {
            int CezaTutari = 0; // CezaTutari adında int değişken tanımladım.
            // dataGridView_borc2'ye giriş yapan öğrencinin aldığı kitapları listeledim. Not: Formda gözükmez ama işlemler için gerekli
            dataGridView_borc2.DataSource = kitapTakibiBLL.GetBookHistoryFromStudenTC(activeStudentTC); // datagrid'i doldur // LİSTELE


            // DataGridView'in her satırını gez
            foreach (DataGridViewRow row in dataGridView_borc2.Rows)
            {
                // Satırın sıfırıncı hücresinin değeri null'dan farkli ise bloğa gir.
                if (row.Cells[0].Value != null)
                {
                    // Kitabın teslim tarihinden bugünün tarihini çıkart.Tarihsel düzeyde aritmatik işlem!
                    DateTime d1 = DateTime.Now;
                    DateTime d2 = Convert.ToDateTime(row.Cells[5].Value);
                    var result = d2.Subtract(d1);

                    // Herhangi bir kitabın teslim tarihi geçmiş ise
                    if (row.Cells[6].Value.ToString() == "" && result.TotalDays < 0) 
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

        private void KitapEkrani_FormClosed(object sender, FormClosedEventArgs e) // Bu form kapanır iken yapılacaklar
        {
            // Secim ekranını göster
            secimEkrani.Show(); 
            // BorcGoster() metodunu çalıştır.
            BorcGoster();
        }

        private void Btn_Kitap_EkleSilGuncelle_Click(object sender, EventArgs e) // Btn_Kitap_EkleSilGuncelle butonuna basılınca yapılacaklar
        {
            // KitapEkleSilGuncelle formunu oluştur.Ve bu formu parametre olarak gönder.
            KitapEkleSilGuncelle kitapEkleSilGuncelle = new KitapEkleSilGuncelle(this);
            // KitapEkleSilGuncelle formunu göster.
            kitapEkleSilGuncelle.Show();
            // Bu formu gizle.
            this.Hide();
        }

        private void Btn_Kitap_Odunc_Click(object sender, EventArgs e) // Btn_Kitap_Odunc butonuna basılınca yapılacaklar
        {
            // Btn_Kitap_Odunc formunu oluştur.Ve bu formu ve aktif öğrencinin tc'sini parametre olarak gönder.
            KitapOduncIade kitapOduncIade = new KitapOduncIade(this, activeStudentTC);
            // kitapOduncIade formunu göster.
            kitapOduncIade.Show();
            // Bu formu gizle.
            this.Hide();
        }

        private void Btn_Kitap_KitapTakibi_Click(object sender, EventArgs e) // Btn_Kitap_KitapTakibi butonuna basılınca yapılacaklar
        {
            // Btn_Kitap_KitapTakibi formunu oluştur.Ve bu formu parametre olarak gönder.
            KitapTakipEkrani kitapTakibi = new KitapTakipEkrani(this);
            // kitapTakibi formunu göster.
            kitapTakibi.Show();
            // Bu formu gizle.
            this.Hide();
        }

        private void Btn_Kitap_OgrenciKitapProfili_Click(object sender, EventArgs e) // Btn_Kitap_OgrenciKitapProfili butonuna basılınca yapılacaklar
        {
            // Btn_Kitap_OgrenciKitapProfili formunu oluştur.Ve bu formu ve aktif öğrencinin tc'sini parametre olarak gönder.
            OgrenciKitapProfilEkrani ogrenciKitapProfilEkrani = new OgrenciKitapProfilEkrani(this, activeStudentTC);
            // ogrenciKitapProfilEkrani formunu göster.
            ogrenciKitapProfilEkrani.Show();
            // Bu formu gizle.
            this.Hide();
        }

        private void Btn_ZedGraph_Click(object sender, EventArgs e) // Btn_ZedGraph butonuna basılınca yapılacaklar
        {
            // Zedgraph formunu oluştur ve bu formu parametre olarak gönder.
            ZedGraph Kitap_Grafik_Ekrani = new ZedGraph(this);
            // Kitap_Grafik_Ekrani formunu göster.
            Kitap_Grafik_Ekrani.Show();
            // Bu formu gizle.
            this.Hide();
        }
    }
}
