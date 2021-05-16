using System.Data; // DataTable sınıfını kullanabilmemiz için eklememiz gerekir.
using KutuphaneOtomasyonu.Entity; // KutuphaneOtomasyonu.Entity katmanındaki sınıflara ulaşmamızı sağlar.
using System.Data.OleDb; // Access veritabanını kullanabilmemiz için tanımlamalıyız.

namespace KutuphaneOtomasyonu.DAL
{
    public class OduncKitapDAL
    {
        // GLOBAL TANIMLAMALAR // DATABASE BAĞLANTISI
        // Burdaki readonly oluşturulan nesnelelerin sadece okunacağını belirtiyor.
        readonly OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb"); // Access db bağlantısı
        readonly DataTable Tablo = new DataTable(); // DataTable sınıfından nesne ürettim.

        public void OduncAl(OduncKitap oduncKitap) // Kitabın öğrenci tarafından ödünç alınmasını sağlayan fonksiyon.
        {
            Baglanti.Open(); // Bağlantıyı açıyorum.
            // Database sorgusunu Query'e atıyorum.
            string Query = $"insert into OduncKitap(KitabıAlanOgrenci_Tcno,VerilenKitabin_SeriNo,VerilenKitabin_Ad,Kitap_AlimTarihi,Kitap_TeslimTarihi) values(@TC,@SeriNo,@Ad,@Alim,@Teslim)";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            // Parametreden gelen model bilgilerini database sorgusuna ekliyoruz.
            Komut.Parameters.AddWithValue("@TC", oduncKitap.KitabıAlanOgrenci_Tcno);
            Komut.Parameters.AddWithValue("@SeriNo", oduncKitap.VerilenKitabin_SeriNo);
            Komut.Parameters.AddWithValue("@Ad", oduncKitap.VerilenKitabin_Ad);
            Komut.Parameters.AddWithValue("@Alim", oduncKitap.Kitap_AlimTarihi.ToString());
            Komut.Parameters.AddWithValue("@Teslim", oduncKitap.Kitap_TeslimTarihi.ToString());
            // Komutu çalıştırıyorum
            Komut.ExecuteNonQuery();
            Baglanti.Close(); // Bağlantı kapanıyor.
        }

        public void IadeEt(OduncKitap oduncKitap) // Alınan kitabın iade edilmesini sağlayan fonksiyon.
        {
            Baglanti.Open(); // Bağlantı açılıyor.
            // Db sorgusu Query stringine aktarılıyor.
            // Sorgu: OduncKitap tablosundan verilen kitabın serino'sunu bul ve o satırı sil.
            string Query = "delete *from OduncKitap where VerilenKitabin_SeriNo='" + oduncKitap.VerilenKitabin_SeriNo + "' ";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            // Komutu işleme alıyorum.
            Komut.ExecuteNonQuery();
            Baglanti.Close(); // Bağlantı kapanıyor.
        }

        public DataTable OduncKitaplariSirala() // Alınan ödünç kitapların listelenmesini sağlayan fonksiyon.DataTable türünde veri döndürür.
        {
            Tablo.Clear(); // Tabloyu temizle.
            Baglanti.Open(); // Bağlantıyı aç.
            // Adapter oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from OduncKitap", Baglanti);
            // Gelen bilgileri tabloya aktar.
            Adapter.Fill(Tablo);
            Baglanti.Close(); // Bağlantıyı kapat.
            return Tablo; // Tabloyu döndür.
        }

    }
}
