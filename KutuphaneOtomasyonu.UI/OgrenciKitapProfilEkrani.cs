using System;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneOtomasyonu.BLL; // BLL katmanındaki sınıflara erişim için

namespace KutuphaneOtomasyonu
{
    public partial class OgrenciKitapProfilEkrani : Form
    {
        // Tanımlamalar

        public KitapEkrani kitapEkrani;
        KitapTakibiBLL kitapTakibiBLL;
        public string activeStudentTC;
        public OgrenciKitapProfilEkrani(KitapEkrani kitapEkrani, string activeStudentTC) // 2 Parametre almış Constructor
        {
            InitializeComponent();

            // Gelen parametreleri oluşturduğumuz nesnelere atadık.
            this.kitapEkrani = kitapEkrani;
            kitapTakibiBLL = new KitapTakibiBLL();
            this.activeStudentTC = activeStudentTC;
        }

        private void OgrenciKitapProfilEkrani_Load(object sender, EventArgs e) // Form yüklenir iken yapılacaklar
        {
            this.CancelButton = Btn_KitapIslemlerineDon4;

            dataGridView_OgrenciKitapProfili.DataSource = kitapTakibiBLL.GetBookHistoryFromStudenTC(activeStudentTC); // datagrid'i doldur // LİSTELE

            // Satırları kullanıcının kitap durumuna göre boyama işlemi
            // DataGridView'deki her satırı gez
            foreach (DataGridViewRow row in dataGridView_OgrenciKitapProfili.Rows) 
            {
                // satırın ilk hücresi null dan farklı ise if bloğuna gir.
                if(row.Cells[0].Value != null)
                {
                    // Kitabın teslim tarihinden bugünün tarihini çıkart.Tarihsel düzeyde aritmatik işlem!
                    DateTime d1 = DateTime.Now;
                    DateTime d2 = Convert.ToDateTime(row.Cells[5].Value);
                    var result = d2.Subtract(d1);

                    // Teslim tarihi dolu ise satırı yeşile boya
                    if (row.Cells[6].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    // Teslim tarihi geçmiş ise
                    else if(row.Cells[6].Value.ToString() == "" && result.TotalDays < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    // Teslim tarihine iki gün var ise
                    else if (row.Cells[6].Value.ToString() == "" && (result.TotalDays < 2 && result.TotalDays > 0))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    // Teslim etmesi gereken tarih geçmemiş ise
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            } // end of the foreach
        }

        private void Btn_KitapIslemlerineDon4_Click(object sender, EventArgs e) // Çıkış Butonu
        {
            // Bu formu kapat.
            this.Close();
        }

        private void OgrenciKitapProfilEkrani_FormClosed(object sender, FormClosedEventArgs e) // Form kapanır iken yapılacaklar
        {
            // kitapEkrani formunu göster.
            kitapEkrani.Show();
        }

    }
}
