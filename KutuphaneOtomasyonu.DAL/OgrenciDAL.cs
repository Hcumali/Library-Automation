using System.Data; // DataTable sınıfını kullanabilmemiz için eklememiz gerekir.
using KutuphaneOtomasyonu.Entity; // KutuphaneOtomasyonu.Entity katmanındaki sınıflara ulaşmamızı sağlar.
using System.Data.OleDb; // Access veritabanını kullanabilmemiz için tanımlamalıyız.


namespace KutuphaneOtomasyonu.DAL
{
    public class OgrenciDAL
    {
        // GLOBAL TANIMLAMALAR // DATABASE BAĞLANTISI
        // Burdaki readonly oluşturulan nesnelelerin sadece okunacağını belirtiyor.
        readonly OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb"); // Access database bağlantısı
        readonly DataTable Tablo = new DataTable(); // DataTable sınıfından nesne ürettim.
       
        public void AddStudent(Ogrenci student) // Öğrenci kayıtını gerçekleştiren - Database işlemlerini yapan fonksiyon.
        { 
            Baglanti.Open();  // Oluşturduğumuz database bağlantısını açıyoruz.
            // Database sorgumuzu yazıyoruz. Yazılan parametreleri Ogrenci tablosuna kaydet.
            string Query = $"insert into Ogrenci(Tcno,Ad,Soyad,Telno,Meslek,KayitTarihi) values(@Tcno,@Ad,@Soyad,@Telno,@Meslek,@KayitTarihi)";
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            Komut.Parameters.AddWithValue("@Tcno", student.Tcno);
            Komut.Parameters.AddWithValue("@Ad", student.Ad);
            Komut.Parameters.AddWithValue("@Soyad", student.Soyad);
            Komut.Parameters.AddWithValue("@Telno", student.Telno);
            Komut.Parameters.AddWithValue("@Meslek", student.Meslek);
            Komut.Parameters.AddWithValue("@KayitTarihi", student.Kayit_Tarihi.ToString());
            Komut.ExecuteNonQuery(); // Komutu işlet.
            Baglanti.Close(); // Oluşturduğumuz database bağlantısını kapatıyoruz.
        }
        public DataTable GetAllStudents() // Bütün öğrenci bilgilerini döndüren - Database işlemlerini yapan fonksiyon.
        {
            Tablo.Clear(); // Tabloyu temizliyoruz - tablonun güncel olması bakımından önceki sorgudan bilgiler kalmasın diye.
            Baglanti.Open(); // Oluşturduğumuz database bağlantısını açıyoruz.
            // 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Ogrenci", Baglanti);
            // Sorgudan gelen bilgiler ile tabloyu doldur.
            Adapter.Fill(Tablo);
            Baglanti.Close();// Bağlantıyı kapat.
            // Tabloyu döndür.
            return Tablo;
        }

        public void DeleteStudent(Ogrenci student) // Seçilen öğrencinin veritabanından silinme işlemini gerçekleştiren fonksiyon.
        {
            Baglanti.Open(); // Database bağlantımızı açıyoruz.
            // Sorgumuzu oluşturup Query stringine atıyoruz.
            string Query = "delete *from Ogrenci where Tcno='" + student.Tcno + "' ";
            // 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            // Oluşturduğumuz komutu çalıştırıyoruz.
            Komut.ExecuteNonQuery();
            Baglanti.Close(); // Bağlantımızı kapatıyoruz.
        }

        public void UpdateStudent(Ogrenci student) // Seçilen öğrencinin bilgilerini güncelleme işlemini gerçekleştiren fonksiyon.
        {
            Baglanti.Open(); // Oluşturduğumuz database bağlantısını açıyoruz.
            // Database sorgusu.
            string Query = "update Ogrenci set Ad='" + student.Ad + "', Soyad='" + student.Soyad + "', Telno='" + student.Telno + "', Meslek='" + student.Meslek + "' where Tcno='" + student.Tcno + "' ";
            // 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti);
            Komut.ExecuteNonQuery(); // Komutu çalıştır.
            Baglanti.Close(); // Bağlantıyı kapat
        }

        public bool isThereStudent(string tc) // Anasayfadaki giriş işlemi için veritabanında kullanıcı varlığını sorgulamamızı sağlayan fonksiyon.
        {
            DataTable tablo1 = new DataTable(); // DataTable sınıfından nesne üretiyoruz.
            Baglanti.Open(); // Database bağlantımızı açıyoruz.
            // 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbDataAdapter Adapter = new OleDbDataAdapter("select *from Ogrenci where Tcno like '"+ tc +"' ", Baglanti);
            // Gelen sonuçlar ile tablomuzu dolduruyoruz.
            Adapter.Fill(tablo1);
            Baglanti.Close();// Bağlantımızı kapatıyoruz.
            
            if(tablo1.Rows.Count == 0) // Eğer tablo1 de veri yoksa boş ise false döndür
            {
                return false;
            }
            else // girilen tc no ile veritabanında öğrenci bulunmuşsa true döndür
            {
                return true;
            }
        }

        public string getName(string activeStudentTC)
        // Seçim ekranında karşılama amaçlı 'Hoşgeldiniz + isim' şeklindeki label görünümü için isim değişkenini almamıza yönelik işlemleri yapan fonksiyon.
        {
            Baglanti.Open(); // Bağlantı açılır
            string Name = "" ; // Name adında boş bir string değişken oluşturulur.
            string Query = "select Ad from Ogrenci where Tcno like '" + activeStudentTC + "' "; // Sorgu ifademiz, Query stringine atanır.
            OleDbCommand Komut = new OleDbCommand(Query, Baglanti); // 1. parametre: db sorgusu, 2. paramete: db bağlantısı
            OleDbDataReader reader = Komut.ExecuteReader();
            while (reader.Read())
            {
                Name = reader.GetValue(0).ToString();
            }
            Baglanti.Close();

            if(Name != null ) // Name null dan farklı ise while döngüsünün içinde atanan Name değişkenini döndür
            {
                return Name;
            }
            else // Name null ise while döngüsüne zaten girmiyecek.Boş string atanmış olan Name değişkenini döndür.
            {
                return Name;
            }
        }
    }
}
