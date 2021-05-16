using System;
using System.Drawing;
using System.Windows.Forms;                 
using ZedGraph;  // ZedGraph Kütüphanesini kullanabilmemize olanak sağlar.

namespace KutuphaneOtomasyonu
{
    public partial class ZedGraph : Form
    {
        public KitapEkrani kitapEkrani; // KitapEkrani formundan yeni form oluştur.
        GraphPane _graphPane; // GraphPane sınıfından bir nesne tanımla.

        public ZedGraph(KitapEkrani kitapEkrani)   // Constructor with parameter
        {
            InitializeComponent();

            _graphPane = zedGraphControl.GraphPane; // zedGraphControl sınıfından bir nesne oluşturduk
            this.kitapEkrani = kitapEkrani; // Oluşturduğumuz forma gelen parametreyi ata.
        }

        private void Btn_KitapIslemlerineDon_Zed_Click(object sender, EventArgs e) // Çıkış Butonu
        {
            // Bu formu kapat.
            this.Close();
        }

        private void DrawGraph() // Grafiği çizdiriyoruz.
        {
            // Başlığı ve axis label'lerini tanımlıyoruz.

            _graphPane.Title.Text = "Kütüphanedeki Kitap Türlerine Göre Kitap Sayısı";
            _graphPane.XAxis.Title.Text = "Kitap Türleri";
            _graphPane.YAxis.Title.Text = "Kitap Sayısı";


            double[] y0 = new double[1];
            y0[0] = 34;  // 1. Kitap Türünün Değeri


            double[] y1 = new double[1];
            y1[0] = 78;  // 2. Kitap Türünün Değeri


            double[] y2 = new double[1];
            y2[0] = 21;  // 3. Kitap Türünün Değeri


            double[] y3 = new double[1];
            y3[0] = 51;  // 4. Kitap Türünün Değeri


            double[] y4 = new double[1];
            y4[0] = 80;  // 5. Kitap Türünün Değeri


            // Ve ilgili grafiği çiziyoruz
            // Bar Graph çizeceğiz

            BarItem CurveRoman; // BarItem sınıfından bir nesne türetiyoruz.
            CurveRoman = _graphPane.AddBar("Roman", null, y0, Color.Blue); // Grafiğe bar ekliyoruz. Parametreler : ad,renk
            _graphPane.XAxis.Type = AxisType.Text; // Type veriyoruz.
            _graphPane.BarSettings.Base = BarBase.X; // Base
            _graphPane.AxisChange(); // Değişiklikleri algıla

            BarItem CurveBiyografi; // BarItem sınıfından bir nesne türetiyoruz.
            CurveBiyografi = _graphPane.AddBar("Tarih", null, y1, Color.Red); // Grafiğe bar ekliyoruz. Parametreler : ad,renk
            _graphPane.XAxis.Type = AxisType.Text; // Type veriyoruz.
            _graphPane.BarSettings.Base = BarBase.X; // Base
            _graphPane.AxisChange(); // Değişiklikleri algıla

            BarItem CurveOtobiyografi; // BarItem sınıfından bir nesne türetiyoruz.
            CurveOtobiyografi = _graphPane.AddBar("Otobiyografi", null, y2, Color.Yellow); // Grafiğe bar ekliyoruz. Parametreler : ad,renk
            _graphPane.XAxis.Type = AxisType.Text; // Type veriyoruz.
            _graphPane.BarSettings.Base = BarBase.X; // Base
            _graphPane.AxisChange(); // Değişiklikleri algıla

            BarItem CurveHikaye; // BarItem sınıfından bir nesne türetiyoruz.
            CurveHikaye = _graphPane.AddBar("Hikaye", null, y3, Color.Green); // Grafiğe bar ekliyoruz. Parametreler : ad,renk
            _graphPane.XAxis.Type = AxisType.Text; // Type veriyoruz.
            _graphPane.BarSettings.Base = BarBase.X; // Base
            _graphPane.AxisChange(); // Değişiklikleri algıla

            BarItem CurveSeyehatname; // BarItem sınıfından bir nesne türetiyoruz.
            CurveSeyehatname = _graphPane.AddBar("Seyehatname", null, y4, Color.Black); // Grafiğe bar ekliyoruz. Parametreler : ad,renk
            _graphPane.XAxis.Type = AxisType.Text; // Type veriyoruz.
            _graphPane.BarSettings.Base = BarBase.X; // Base
            _graphPane.AxisChange(); // Değişiklikleri algıla

        }

        private void ZedGraph_FormClosed(object sender, FormClosedEventArgs e) // Form kapanır iken yapılacaklar
        {
            // kitapEkrani formunu göster
            kitapEkrani.Show();
        }

        private void ZedGraph_Load(object sender, EventArgs e) // Form yüklenir iken yapılacaklar
        {
            // cancel butonunu tanımla
            this.CancelButton = Btn_KitapIslemlerineDon_Zed;
            // DrawGraph metodunu çağırarak, Zedgraph kütüphanesi yardımıyla bir grafik çizdir.
            DrawGraph();
        }

    }
}
