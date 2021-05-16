using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class KitapOduncIade : Form
    {
        KitapEkrani kitapEkrani; // KitapEkrani formundan yeni nesne tanımlama
        public string activeStudentTC; // activeStudentTC isimli string tanımlama
        public KitapOduncIade(KitapEkrani kitapEkrani, string activeStudentTC)
        {
            InitializeComponent();

            // Gelen parametreleri oluşturduğumuz nesne ve değişkenlere ata.
            this.kitapEkrani = kitapEkrani;
            this.activeStudentTC = activeStudentTC;
        }

        private void Btn_KitapIslemlerineDon2_Click(object sender, EventArgs e) // Çıkış butonu
        {
            this.Close(); // Bu formu kapat.
        }

        private void KitapOdunc_FormClosed(object sender, FormClosedEventArgs e) // Form kapanır iken yapılacaklar
        {
            kitapEkrani.Show(); // kitapEkrani formunu göster.
        }

        private void KitapOdunc_Load(object sender, EventArgs e) // Form yüklenir iken yapılacaklar
        {
            // Cancel butonunu belirle.
            this.CancelButton = Btn_KitapIslemlerineDon2;
        }

        private void Btn_Odunc_Click(object sender, EventArgs e) // KitapOdunc formuna gidiş butonu
        {
            // Yeni bir form oluştur, o formu göster, bu formu gizle
            KitapOdunc kitapOdunc = new KitapOdunc(this, activeStudentTC);
            kitapOdunc.Show();
            this.Hide();
        }

        private void Btn_Iade_Click(object sender, EventArgs e) // KitapIade formuna gidiş butonu
        {
            // Yeni bir form oluştur, o formu göster, bu formu gizle
            KitapIade kitapIade = new KitapIade(this, activeStudentTC);
            kitapIade.Show();
            this.Hide();
        }
    }
}
