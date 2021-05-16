using System.Data; // DataTable nesnesini kullanabilmemiz için ekledim.
using KutuphaneOtomasyonu.Entity; //  KutuphaneOtomasyonu.Entity'deki sınıflara ulaşmamızı sağlar.
using KutuphaneOtomasyonu.DAL; // KutuphaneOtomasyonu.Dal'daki sınıflara ulaşmamızı sağlar.

namespace KutuphaneOtomasyonu.BLL
{
    public class OgrenciBLL
    {
        OgrenciDAL studentDAL; // ÖgrenciDAL sınıfından nesne tanımlıyoruz.
        public OgrenciBLL() // constructor
        {
            studentDAL = new OgrenciDAL(); // OgrenciDAL sınıfından tanımladığımız nesneyi oluşturdum.
        }

        public void AddStudent(Ogrenci student) 
        {
            // Öğrenci sınıfından bir parametre alıyor.
            // Öğrenci eklememiz için DAL katmanındaki fonksiyona istek yolluyor.
            studentDAL.AddStudent(student);
        }

        public DataTable GetAllStudents() 
        {
            // Öğrenci sınıfından bir parametre alıyor.
            // Bütün öğrenci bilgilerini çekmemiz için DAL katmanındaki fonksiyona istek yolluyor.Ve DataTable türünde veri dönüyor.
            return studentDAL.GetAllStudents();
        }

        public void DeleteStudent(Ogrenci student) 
        {
            // Öğrenci sınıfından bir parametre alıyor.
            // Seçilen öğrenciyi silmemiz için DAL katmanındaki fonksiyona istek yolluyor.
            studentDAL.DeleteStudent(student);
        }

        public void UpdateStudent(Ogrenci student) 
        {
            // Öğrenci sınıfından bir parametre alıyor.
            // Seçilen öğrencinin bilgilerini güncellememiz için DAL katmanındaki fonksiyona istek yolluyor.
            studentDAL.UpdateStudent(student);
        }

        public bool isThereStudent(string tc) 
        {
            // String türünde bir parametre alıyor.
            // Anasayfadaki giriş bölümünde tc girildikten sonra database'de böyle bir kullanıcının varlığını kontrol amaçlı -
            // DAL katmanındaki fonksiyona istek yolluyor.
            return studentDAL.isThereStudent(tc);
        }

        public string getName(string activeStudentTC)
        {
            // String türünde bir parametre alıyor.
            // Seçim ekranında karşılama amaçlı 'Hoşgeldiniz + isim' şeklindeki -
            // label görünümü için isim değişkenini almamıza yarayan fonksiyona istek atarız.
            return studentDAL.getName(activeStudentTC);
        }
    }
}
