using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL katmanındaki sınıflara erişim için

namespace KutuphaneOtomasyonu
{
    public partial class KitapTakipEkrani : Form
    {
        // Tanımlamalar
        public KitapEkrani kitapEkrani;
        KitapTakibiBLL kitapTakibiBLL;

        public KitapTakipEkrani(KitapEkrani kitapEkrani) // Constructor
        {
            InitializeComponent();

            // Gelen parametreyi oluşturduğumuz forn ekranına ata
            this.kitapEkrani = kitapEkrani;
            // kitapTakibiBLL sınıfından nesne oluşturuyoruz.
            kitapTakibiBLL = new KitapTakibiBLL();
        }

        private void KitapTakibi_Load(object sender, EventArgs e) // Form yüklenir iken yapılacaklar.
        {
            // Accept ve Cancel Butonunu ayarla.
            this.AcceptButton = Btn_Kitap_Ara;
            this.CancelButton = Btn_KitapIslemlerineDon3;
        }

        private void KitapTakibi_FormClosed(object sender, FormClosedEventArgs e) // Form kapanırken yapılacaklar
        {
            // kitapEkrani formunu göster.
            kitapEkrani.Show();
        }

        private void Btn_KitapIslemlerineDon3_Click(object sender, EventArgs e) // Çıkış butonu
        {
            // Bu formu kapat.
            this.Close();
        }

        private void Btn_Kitap_Ara_Click(object sender, EventArgs e) // Kitap arama butonu
        {
            // string input stringine textboxt'daki texti ata.
            String input = textBox_KitapTakibi.Text;

            if (radioButton_Ad.Checked == true && textBox_KitapTakibi.Text != "") // Ad radio buttonu seçilmiş ise ve textbox dolu ise bloğa gir
            {
                if(kitapTakibiBLL.isThereBookUsingName(textBox_KitapTakibi.Text)) // Böyle bir kitap var ise
                {
                    // Kitap bilgilerini ve o kitabı alanların listesini datagridviewlere bas.
                    dataGridView_Kitap_Bilgi.DataSource = kitapTakibiBLL.GetBookInfoUsingName(input);
                    dataGridView_Kitap_Gecmis.DataSource = kitapTakibiBLL.GetBookHistoryUsingName(input);
                    textBox_KitapTakibi.Text = "";
                }
                else
                {
                    MessageBox.Show("Girdiğiniz girdiye dair herhangi bir sonuç bulunamadı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }

            else if(radioButton_SeriNo.Checked == true && textBox_KitapTakibi.Text != "") // Serino radio buttonu seçilmiş ise ve textbox dolu ise bloğa gir
            {
                if (kitapTakibiBLL.isThereBookUsingID(textBox_KitapTakibi.Text)) // Böyle bir kitap var ise
                {
                    // Kitap bilgilerini ve o kitabı alanların listesini datagridviewlere bas.
                    dataGridView_Kitap_Bilgi.DataSource = kitapTakibiBLL.GetBookInfoUsingID(input);
                    dataGridView_Kitap_Gecmis.DataSource = kitapTakibiBLL.GetBookHistoryUsingID(input);
                    textBox_KitapTakibi.Text = "";
                }
                else
                {
                    MessageBox.Show("Girdiğiniz girdiye dair herhangi bir sonuç bulunamadı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }

            else // Diğer durumlar
            {
                // Uyarı mesajı bas.
                MessageBox.Show("Radio Button'lardan birini seçmelisiniz ve giriş metniniz boş olmamalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        } // Fonksiyonun sonu


    }
}
