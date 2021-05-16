using System.Data; // DataTable nesnesini kullanabilmemiz için ekledim.
using KutuphaneOtomasyonu.Entity; //  KutuphaneOtomasyonu.Entity'deki sınıflara ulaşmamızı sağlar.
using KutuphaneOtomasyonu.DAL; // KutuphaneOtomasyonu.Dal'daki sınıflara ulaşmamızı sağlar.

namespace KutuphaneOtomasyonu.BLL
{
    public class KitapBLL
    {
        KitapDAL kitapDAL;  // KitapDAL sınıfından nesne tanımlıyoruz.
        public KitapBLL() // constructor
        {
            kitapDAL = new KitapDAL(); // KitapDAL sınıfından tanımladığımız nesneyi oluşturdum.
        }

        public void AddBook(Kitap book) 
        {
            // Kitap eklememiz için DAL katmanındaki fonksiyona istek yolluyor.
            // Ve Kitap sınıfından bir parametre alıyor.
            kitapDAL.AddBook(book);
        }

        public DataTable GetAllBooks() 
        {
            // Bütün kitap bilgilerini çekmemiz için DAL katmanındaki fonksiyona istek yolluyor.
            // Ve DataTable türünde veri dönüyor.
            return kitapDAL.GetAllBooks();
        }

        public void DeleteBook(Kitap book)
        {
            // Seçilen kitabı silmemiz için DAL katmanındaki fonksiyona istek yolluyor.
            // Ve Kitap sınıfından bir parametre alıyor.
            kitapDAL.DeleteBook(book);
        }

        public void UpdateBook(Kitap book) 
        {
            // Seçilen kitabın bilgilerini güncellememiz için DAL katmanındaki fonksiyona istek yolluyor.
            // Ve Kitap sınıfından bir parametre alıyor.
            kitapDAL.UpdateBook(book);
        }
    }
}
