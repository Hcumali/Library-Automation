using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL katmanındaki class'lara erişim sağlar
using KutuphaneOtomasyonu.Entity; // Entity katmanındaki class'lara erişim sağlar

namespace KutuphaneOtomasyonu
{
    public partial class KitapIade : Form
    {
        public string activeStudentTC; // KitapOduncIade adında stringimizi oluşturuyoruz.
        KitapOduncIade kitapOduncIade; // KitapOduncIade formunu tanımlıyoruz

        // Sınıflardan nesne tanımlamalarımız
        OduncKitapBLL oduncKitapBLL;
        KitapTakibiBLL kitapTakibiBLL;
        public KitapIade(KitapOduncIade kitapOduncIade, string activeStudentTC) // Constructor
        {
            InitializeComponent();
            // Yukarıda tanımladığımız nesneleri parametreden gelen değerlere atıyoruz.
            // Bu işlemi aktif öğrencinin tc nosunu diğer formlara taşıyabilmek ve çeşitli işlemlerde aktif kullanabilmek için yapıyorum.
            this.kitapOduncIade = kitapOduncIade;
            this.activeStudentTC = activeStudentTC;

            // Tanımladığımız nesneleri oluşturuyoruz.
            oduncKitapBLL = new OduncKitapBLL();
            kitapTakibiBLL = new KitapTakibiBLL();
        }

        private void KitapIade_Load(object sender, EventArgs e) // Form yüklenir iken yapılacaklar
        {
            // Cancel butonunu ata.
            this.CancelButton = Btn_AltMenu2;
            // DataGridView için listele metodumuz
            listele();
        }

        private void Btn_AltMenu2_Click(object sender, EventArgs e) // Çıkış butonuna tıklanınca
        {
            // Bu formu kapat
            this.Close();
        }

        private void KitapIade_FormClosed(object sender, FormClosedEventArgs e) // Form kapanır iken yapılacaklar
        {
            // kitapOduncIade formunu göster.
            kitapOduncIade.Show();
        }

        public void listele() // Listele metodumuz
        {
            // oduncKitapBLL sınıfındaki OduncKitaplariSirala metodumuzu kullanarak dönen değeri datagridviewimizin datasource'sine aktarıyoruz.
            dataGridView_IadeKitapListesi.DataSource = oduncKitapBLL.OduncKitaplariSirala();
        }

        private void Btn_Kitap_iadeEt_Click(object sender, EventArgs e) // Kitap iade etme butonu
        {
            if(textBox_Iade_SeriNo.Text == "" || textBox_Iade_KitapIsim.Text == "") // Tablodan herhangi bir kitap seçilmemiş ise
            {
                MessageBox.Show("Lütfen iade etmek istediğiniz kayıdı tablodan seçiniz!", "Uyarı");
            }
            else // Herhangi bir problem yok ise
            {
                // OduncKitap sınıfında nesne türet.
                OduncKitap kitapIade = new OduncKitap();
                // nesnenin serino'suna tablodan serinoyu ata.
                kitapIade.VerilenKitabin_SeriNo = dataGridView_IadeKitapListesi.CurrentRow.Cells["VerilenKitabin_SeriNo"].Value.ToString();

                // oduncKitapBLL sınıfındaki IadeEt metoduna oluşturduğumuz nesneyi yolla.
                oduncKitapBLL.IadeEt(kitapIade);

                // -- Kitap Takip Ekranı için güncellenecek tablo
                KitapTakibi kitapTakibi = new KitapTakibi();
                kitapTakibi.Kitap_Serino = textBox_Iade_SeriNo.Text;
                kitapTakibi.Kitap_Ad = textBox_Iade_KitapIsim.Text;
                kitapTakibi.Kitap_TeslimEdilenTarih = DateTime.Now.ToString();
                kitapTakibiBLL.KitapTakipKayitiGuncelle(kitapTakibi);
                // ----

                // Texboxtların içini temizle.
                textBox_Iade_SeriNo.Text = "";
                textBox_Iade_KitapIsim.Text = "";

                // Tablonun güncellenmesi için listele() metodunu çağır.
                listele();
                // Ekrana bilgilendirme mesajı bas.
                MessageBox.Show("Kitabınız başarı ile iade edildi !", "İade");
            }
        }

        private void dataGridView_IadeKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e) // Herhangi bir datagridview hücresine tıklanınca yapılacaklar
        {
            // Serino ve kitap ismini değiştirilememesi için readOnly yaptım.
            textBox_Iade_SeriNo.ReadOnly = true;
            textBox_Iade_KitapIsim.ReadOnly = true;
            // Seri no ve kitap adını Seçtiğimiz satırın ilgili hücrelerinden çekilerek textboxın textine atanır.
            textBox_Iade_SeriNo.Text = dataGridView_IadeKitapListesi.CurrentRow.Cells["VerilenKitabin_SeriNo"].Value.ToString();
            textBox_Iade_KitapIsim.Text = dataGridView_IadeKitapListesi.CurrentRow.Cells["VerilenKitabin_Ad"].Value.ToString();
        }
    }
}
