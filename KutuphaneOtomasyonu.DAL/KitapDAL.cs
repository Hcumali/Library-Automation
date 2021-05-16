using System.Data; // DataTable sınıfını kullanabilmemiz için eklememiz gerekir.
using KutuphaneOtomasyonu.Entity; // KutuphaneOtomasyonu.Entity katmanındaki sınıflara ulaşmamızı sağlar.
using System.Data.OleDb; // Access veritabanını kullanabilmemiz için tanımlamalıyız.

namespace KutuphaneOtomasyonu.DAL
{
    public class KitapDAL
    {
        // GLOBAL TANIMLAMALAR // DATABASE BAĞLANTISI
        // Burdaki readonly oluşturulan nesnelelerin sadece okunacağını belirtiyor.
        readonly OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb"); // Access db bağlantısı
        readonly DataTable Tablo = new DataTable(); // DataTable sınıfından nesne ürettim.

        public void AddBook(Kitap book) // Kitap kayıtını gerçekleştiren - Database işlemlerini yapan fonksiyon.
        {
            Baglanti.Open(); // Database Bağlantısı açılıyor.
            // Database sorgusunu yazıyorum.
            string Query = $"insert into Kitap(Serino,Ad,Tur,SayfaSayisi,Yazar,BasimTarihi) values(@Serino,@Ad,@Tur,@SayfaSayisi,@Yazar,@BasimTarihi)";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            // Db'e eklenecek bilgiler atanıyor.
            Komut.Parameters.AddWithValue("@Serino", book.Serino);
            Komut.Parameters.AddWithValue("@Ad", book.Ad);
            Komut.Parameters.AddWithValue("@Tur", book.Tur);
            Komut.Parameters.AddWithValue("@SayfaSayisi", book.Sayfa_Sayisi.ToString());
            Komut.Parameters.AddWithValue("@Yazar", book.Yazar);
            Komut.Parameters.AddWithValue("@BasimTarihi", book.BasimTarihi);
            // Komut çalıştırılıyor.
            Komut.ExecuteNonQuery();
            Baglanti.Close(); // Bağlantıyı kapattım.
        }
        public DataTable GetAllBooks() // Bütün kitap bilgilerini döndüren - Database işlemlerini yapan fonksiyon.
        {
            Tablo.Clear(); // Tabloyu temizliyoruz - tablonun güncel olması bakımından önceki sorgudan bilgiler kalmasın diye.
            Baglanti.Open(); // Bağlantıyı Açıyoruz
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Kitap", Baglanti);
            // Gelen sonuçları tabloya döşüyoruz.
            Adapter.Fill(Tablo);
            Baglanti.Close(); // Bağlantıyı kapatıyoruz.
            return Tablo; // Tabloyu döndür diyorum.
        }
        public void DeleteBook(Kitap book) // Seçilen kitabın veritabanından silinme işlemini gerçekleştiren fonksiyon.
        {
            Baglanti.Open(); // Bağlantıyı açıyoruz.
            // Database Sorgusunu Query'e atıyorum.
            string Query = "delete *from Kitap where Serino='" + book.Serino + "' ";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            Komut.ExecuteNonQuery(); // Komutu işleme sokuyorum.
            Baglanti.Close(); // Bağlantıyı kapatıyorum.
        }
        public void UpdateBook(Kitap book) // Seçilen kitabın bilgilerini güncelleme işlemini gerçekleştiren fonksiyon.
        {
            Baglanti.Open(); // Bağlantıyı açıyorum.
            // Database sorgumu Query'e atıyorum.
            string Query = "update Kitap set Ad='" + book.Ad + "', Tur='" + book.Tur + "', SayfaSayisi='" + book.Sayfa_Sayisi + "', Yazar='" + book.Yazar + "', BasimTarihi='" + book.BasimTarihi + "' where Serino='" + book.Serino + "' ";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            Komut.ExecuteNonQuery(); // Komutu işleme sokuyorum.
            Baglanti.Close(); // Bağlantıyı kapatıyorum.
        }
    }
}
