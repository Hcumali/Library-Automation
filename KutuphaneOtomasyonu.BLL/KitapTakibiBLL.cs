using System.Data; // DataTable nesnesini kullanabilmemiz için ekledim.
using KutuphaneOtomasyonu.Entity; //  KutuphaneOtomasyonu.Entity'deki sınıflara ulaşmamızı sağlar.
using KutuphaneOtomasyonu.DAL; // KutuphaneOtomasyonu.Dal'daki sınıflara ulaşmamızı sağlar.

namespace KutuphaneOtomasyonu.BLL
{
    public class KitapTakibiBLL
    {
        KitapTakibiDAL kitapTakibiDAL;  // KitapTakibiDAL sınıfından nesne tanımlıyoruz.
        public KitapTakibiBLL()  // Constructor
        {
            kitapTakibiDAL = new KitapTakibiDAL();  // Üst tarafta tanımladığımız nesneyi oluşturuyoruz.
        }


        public void KitapTakipKayitiOlustur(KitapTakibi kitapTakibi) // Odunc alınan Kitanın takip kayıtını oluşturmaya yarayan fonksiyon
        {
            // Kitap ödünç alındıktan sonra o kitabı istenilen bir zamanda takip edebilmek için Kayıt oluşturur.
            // Bunun için kitapTakibiDAL sınıfındaki KitapTakipKayitiOlustur fonksiyonuna gelen parametre ile istek yollar.
            // KitapTakibi sınıfından bir parametre alır.
            kitapTakibiDAL.KitapTakipKayitiOlustur(kitapTakibi);
        }

        public void KitapTakipKayitiGuncelle(KitapTakibi kitapTakibi) // iade edilen kitabın teslim tarihini güncelleyen fonksiyon.
        {
            // Kitap iade edildikten sonra oluşturulan kitap takibi kayıtının kitap teslim edilme tarihini güncelleyen fonksiyon.
            // Bunun için kitapTakibiDAL sınıfındaki KitapTakipKayitiOlustur fonksiyonuna gelen parametre ile istek yollar.
            // KitapTakibi sınıfından bir parametre alır.
            kitapTakibiDAL.KitapTakipKayitiGuncelle(kitapTakibi);
        }

        public DataTable GetBookHistoryFromStudenTC(string TC)
        {
            // Öğrenci Kitap Profili için üretilmiş bir fonksiyondur.
            // Öğrencinin aldığı kitapların listesini Tcno ile sorgu atarak sonuçları DataTable türünde döndüren fonksiyondur.
            // Parametre olarak string türünde bir tcno alır.
            return kitapTakibiDAL.GetBookHistoryFromStudenTC(TC);
        }

        public DataTable GetBookHistoryUsingName(string input)
        {
            // Adı girilen kitabı daha önce kimlerin aldığını listeleyen ve bu listeyi DataTable türünde döndüren fonksiyon.
            // Parametre olarak string türünde kitap ismi alır.
            return kitapTakibiDAL.GetBookHistoryUsingName(input);
        }

        public DataTable GetBookHistoryUsingID(string input)
        {
            // Serino'su girilen kitabı daha önce kimlerin aldığını listeleyen ve bu listeyi DataTable türünde döndüren fonksiyon.
            // Parametre olarak string türünde kitap ismi alır.
            // Üstteki fonksiyonla farkı; database de sorgu kitap adı yerine kitap serino'su ile yapılmasıdır.
            return kitapTakibiDAL.GetBookHistoryUsingID(input);
        }


        public DataTable GetBookInfoUsingName(string input)
        {
            // Parametre olarak adı girilen kitabın bilgilerini DataTable türünde döndürür.
            return kitapTakibiDAL.GetBookInfoUsingName(input);
        }

        public DataTable GetBookInfoUsingID(string input)
        {
            // Parametre olarak serino'su girilen kitabın bilgilerini DataTable türünde döndürür.
            return kitapTakibiDAL.GetBookInfoUsingID(input);
        }

        public bool isThereBookUsingName(string input)
        {
            // Parametre olarak adı girilen kitabın varlığını sorgulayan, kitabın database de olup olmadığını kontrol eden fonksiyon.
            // Boolean türünde sonuç döndürür. 1 veya 0
            return kitapTakibiDAL.isThereBookUsingName(input);
        }

        public bool isThereBookUsingID(string input)
        {
            // Parametre olarak serino'su girilen kitabın varlığını sorgulayan, kitabın database de olup olmadığını kontrol eden fonksiyon.
            return kitapTakibiDAL.isThereBookUsingID(input);
        }
    }
}
