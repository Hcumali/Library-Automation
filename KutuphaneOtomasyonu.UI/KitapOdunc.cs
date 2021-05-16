using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL;
using KutuphaneOtomasyonu.Entity;

namespace KutuphaneOtomasyonu
{
    public partial class KitapOdunc : Form
    {
        // Tanımlamalar
        public string activeStudentTC;
        OgrenciBLL ogrenciBLL;
        KitapBLL kitapBLL;
        OduncKitapBLL oduncKitapBLL;
        KitapTakibiBLL kitapTakibiBLL;
        KitapOduncIade kitapOduncIade;

        public KitapOdunc(KitapOduncIade kitapOduncIade, string activeStudentTC)
        {
            InitializeComponent();

            // Oluşturmalar
            this.kitapOduncIade = kitapOduncIade;
            this.activeStudentTC = activeStudentTC;
            kitapBLL = new KitapBLL();
            oduncKitapBLL = new OduncKitapBLL();
            ogrenciBLL = new OgrenciBLL();
            kitapTakibiBLL = new KitapTakibiBLL();
        }

        private void KitapOdunc_Load(object sender, EventArgs e) // Form yüklenir iken
        {
            // Labelin textini değiştir ve cancel butonu ata.
            label5.Text = "Seçtiğiniz Kitabı\nKaç Gün İçin\nÖdünç Almak İstiyorsunuz ?";
            this.CancelButton = Btn_AltMenu1;
            // listele metodunu çağır.
            listele();
        }

        public void listele()
        {
            // KitapBLL sınıfından GetAllBooks() metodunu çağır gelen veriyi dataGridView_OduncKitapListesi'in dataSourcesine ata.
            dataGridView_OduncKitapListesi.DataSource = kitapBLL.GetAllBooks();
        }

        private void Btn_AltMenu1_Click(object sender, EventArgs e) // çıkış butonu
        {
            // formu kapat.
            this.Close();
        }

        private void KitapOdunc_FormClosed(object sender, FormClosedEventArgs e) // form kapanır iken yapılacaklar
        {
            // kitapOduncIade formunu göster
            kitapOduncIade.Show();
        }

        private void dataGridView_OduncKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            
            // textboxlara readOnly özelliği veriyoruz.
            textBox_SeriNo.ReadOnly = true;
            textBox_KitapIsim.ReadOnly = true;

            // Datagridview'in herhangi bir hücresine basılınca ilgili satırın verilerini texbotxlara ata.
            textBox_SeriNo.Text = dataGridView_OduncKitapListesi.CurrentRow.Cells["Serino"].Value.ToString();
            textBox_KitapIsim.Text = dataGridView_OduncKitapListesi.CurrentRow.Cells["Ad"].Value.ToString();
        }

        private void Btn_Kitap_OduncAl_Click(object sender, EventArgs e) // Kitap ödünç alma butonu
        {
            if(textBox_SeriNo.Text == "" || textBox_KacGunOduncAlindi.Text == "" || textBox_KitapIsim.Text == "") // Textboxlar boş değil ise devam et
            {
                MessageBox.Show("Alanlar boş bırakılamaz!","Uyarı");
            }
            else
            {
                // OduncKitap sınıfından nesne oluştur ve oluşan nesnenin özelliklerini doldur.
                OduncKitap oduncKitap = new OduncKitap();

                oduncKitap.KitabıAlanOgrenci_Tcno = activeStudentTC;
                oduncKitap.VerilenKitabin_SeriNo = textBox_SeriNo.Text;
                oduncKitap.VerilenKitabin_Ad = textBox_KitapIsim.Text;
                oduncKitap.Kitap_AlimTarihi = DateTime.Now;
                oduncKitap.Kitap_TeslimTarihi = DateTime.Now.AddDays(Double.Parse(textBox_KacGunOduncAlindi.Text));

                // oduncKitapBLL sınıfından OduncAl metoduna oluşturduğumuz nesneyi yolla.
                oduncKitapBLL.OduncAl(oduncKitap);

                // -- Kitap Takip Ekranı için doldurulacak tablo
                KitapTakibi kitapTakibi = new KitapTakibi();
                kitapTakibi.Ogrenci_TC = activeStudentTC;
                kitapTakibi.Ogrenci_Ad = ogrenciBLL.getName(activeStudentTC);
                kitapTakibi.Kitap_Serino = textBox_SeriNo.Text;
                kitapTakibi.Kitap_Ad = textBox_KitapIsim.Text;
                kitapTakibi.Kitap_OduncAlimTarihi = DateTime.Now;
                kitapTakibi.Kitap_TeslimEdilecekTarih = DateTime.Now.AddDays(Double.Parse(textBox_KacGunOduncAlindi.Text));
                kitapTakibi.Kitap_TeslimEdilenTarih = "";

                kitapTakibiBLL.KitapTakipKayitiOlustur(kitapTakibi);
                // ----


                // Textboxları temizle.
                textBox_SeriNo.Text = "";
                textBox_KitapIsim.Text = "";
                textBox_KacGunOduncAlindi.Text = "";
                // Ekrana uyarı mesajı bas.
                MessageBox.Show("Kitabı başarıyla ödünç aldınız." +
                    " Ceza almamak için belirlenen tarihler arasında kitabı teslim etmeniz rica olunur. İyi okumalar !", "Ödünç Alma İşlemi");
            }

        }
    }
}
