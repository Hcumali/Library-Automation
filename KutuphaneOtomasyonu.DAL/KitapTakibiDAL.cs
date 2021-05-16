using System.Data; // DataTable sınıfını kullanabilmemiz için eklememiz gerekir.
using KutuphaneOtomasyonu.Entity; // KutuphaneOtomasyonu.Entity katmanındaki sınıflara ulaşmamızı sağlar.
using System.Data.OleDb; // Access veritabanını kullanabilmemiz için tanımlamalıyız.

namespace KutuphaneOtomasyonu.DAL
{
    public class KitapTakibiDAL
    {
        // GLOBAL TANIMLAMALAR // DATABASE BAĞLANTISI
        // Burdaki readonly oluşturulan nesnelelerin sadece okunacağını belirtiyor.
        readonly OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb"); // Access db bağlantısı
        readonly DataTable Tablo = new DataTable(); // DataTable sınıfından nesne ürettim.

        // Ödünç alınan kitabın bilgilerini daha sonradan takip edilebilmesi amaçlı kayıt altında tutmayı sağlayan fonksiyon.
        public void KitapTakipKayitiOlustur(KitapTakibi kitapTakibi)  
        {
            Baglanti.Open(); // Bağlantıyı aç
            //Database sorgumuzu Query stringine aktarıyoruz.
            string Query = $"insert into KitapTakibi(Ogrenci_TC,Ogrenci_Ad,Kitap_Serino,Kitap_Ad,Kitap_OduncAlimTarihi,Kitap_TeslimEdilecekTarih,Kitap_TeslimEdilenTarih) values(@TC,@Ad,@Serino,@isim,@Alim,@Teslim1,@Teslim2)";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            // Parametrede gelen modelin bilgilerini db sorgusuna entegre ediyorum.
            Komut.Parameters.AddWithValue("@TC", kitapTakibi.Ogrenci_TC);
            Komut.Parameters.AddWithValue("@Ad", kitapTakibi.Ogrenci_Ad);
            Komut.Parameters.AddWithValue("@Serino", kitapTakibi.Kitap_Serino);
            Komut.Parameters.AddWithValue("@isim", kitapTakibi.Kitap_Ad);
            Komut.Parameters.AddWithValue("@Alim", kitapTakibi.Kitap_OduncAlimTarihi.ToString());
            Komut.Parameters.AddWithValue("@Teslim1", kitapTakibi.Kitap_TeslimEdilecekTarih.ToString());
            Komut.Parameters.AddWithValue("@Teslim2", kitapTakibi.Kitap_TeslimEdilenTarih);
            Komut.ExecuteNonQuery(); // Komutu işleme alıyorum.
            Baglanti.Close(); // Bağlantıyı kapatıyorum.
        }

        // Ödünç alınan kitap, iade edilince teslim tarihini KitapTakibi tablosundan güncelle.
        public void KitapTakipKayitiGuncelle(KitapTakibi kitapTakibi) 
        {
            Baglanti.Open(); // Bağlantıyı aç
            // Db sorgumuzu Query stringine atıyorum.
            string Query = "update KitapTakibi set Kitap_TeslimEdilenTarih='" + kitapTakibi.Kitap_TeslimEdilenTarih + "' where Kitap_Serino='" + kitapTakibi.Kitap_Serino + "' ";
            // Komut oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            // Komutu işleme alıyorum.
            Komut.ExecuteNonQuery();
            Baglanti.Close(); // Bağlantıyı kapıyorum
        }

        // Öğrenci tc'si kullanılarak, o öğrencinin daha önceden almış olduğu bütün kitapları listeleyen fonksiyon.
        public DataTable GetBookHistoryFromStudenTC(string TC) 
        {
            DataTable tablo = new DataTable(); // DataTable sınıfından nesne oluşturuyoruz.
            tablo.Clear(); // tabloyu temizle.
            Baglanti.Open(); // Bağlantıyı aç
            // Adapter oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            // Sorgu: KitapTakibi listesindeki girilen öğrenci_TC'nin aldığı bütün kitapları bana ver.
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from KitapTakibi where Ogrenci_TC='" + TC + "' ", Baglanti);
            // Gelen verileri tabloya ata.
            Adapter.Fill(tablo);
            Baglanti.Close(); // Bağlantıyı kapat.
            return tablo; // Tabloyu döndür.
        }


        public DataTable GetBookInfoUsingName(string input) // Kitabın adına göre, kitabın bilgilerini db'den çek.
        {
            Tablo.Clear(); // Tabloyu temizle.
            Baglanti.Open(); // Bağlantıyı aç.
            // Adapter oluşturuyorum. 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Kitap where Ad='" + input + "' ", Baglanti); 
            // Gelen verileri tabloya ata.
            Adapter.Fill(Tablo);
            Baglanti.Close(); // Bağlantıyı kapat.
            return Tablo; // Tabloyu döndür.
        }

        public DataTable GetBookInfoUsingID(string input) // Kitabın serino'suna göre, kitabın bilgilerini db'den çek.
        {
            DataTable Tablo1 = new DataTable();
            Tablo1.Clear();
            Baglanti.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Kitap where Serino='" + input + "' ", Baglanti);
            Adapter.Fill(Tablo1);
            Baglanti.Close();
            return Tablo1;
        }

        public DataTable GetBookHistoryUsingName(string input) // Kitabın adına göre, daha önceden o kitabı hangi öğrencilerin aldığını listele.
        {
            DataTable Tablo2 = new DataTable();
            Tablo2.Clear();
            Baglanti.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from KitapTakibi where Kitap_Ad='" + input + "' ", Baglanti);
            Adapter.Fill(Tablo2);
            Baglanti.Close();
            return Tablo2;
        }

        public DataTable GetBookHistoryUsingID(string input) // Kitabın serino'suna göre, daha önceden o kitabı hangi öğrencilerin aldığını listele.
        {
            DataTable Tablo3 = new DataTable();
            Tablo3.Clear();
            Baglanti.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from KitapTakibi where Kitap_Serino='" + input + "' ", Baglanti);
            Adapter.Fill(Tablo3);
            Baglanti.Close();
            return Tablo3;
        }

        public bool isThereBookUsingName(string input) // Kitabın adına göre, Database de böyle bir kitap var mı yok mu diye sorgula.
        {
            DataTable Tablo4 = new DataTable();
            Baglanti.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Kitap where Ad like '" + input + "' ", Baglanti);
            Adapter.Fill(Tablo4);
            Baglanti.Close();

            if (Tablo4.Rows.Count == 0) // Eğer tablo1 de veri yoksa boş ise false döndür
            {
                return false;
            }
            else // girilen isim ile veritabanında kitap bulunmuşsa true döndür
            {
                return true;
            }
        }

        public bool isThereBookUsingID(string input) // Kitabın serino'suna göre, Database de böyle bir kitap var mı yok mu diye sorgula.
        {
            DataTable Tablo5 = new DataTable();
            Baglanti.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Kitap where Serino like '" + input + "' ", Baglanti);
            Adapter.Fill(Tablo5);
            Baglanti.Close();

            if (Tablo5.Rows.Count == 0) // Eğer tablo2 de veri yoksa boş ise false döndür
            {
                return false;
            }
            else // girilen serino ile veritabanında kitap bulunmuşsa true döndür
            {
                return true;
            }
        }
    }
}
