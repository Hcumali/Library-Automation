using System.Data; // DataTable nesnesini kullanabilmemiz için ekledim.
using KutuphaneOtomasyonu.Entity; //  KutuphaneOtomasyonu.Entity'deki sınıflara ulaşmamızı sağlar.
using KutuphaneOtomasyonu.DAL; // KutuphaneOtomasyonu.Dal'daki sınıflara ulaşmamızı sağlar.

namespace KutuphaneOtomasyonu.BLL
{
    public class OduncKitapBLL
    {
        OduncKitapDAL oduncKitapDAL; // OduncKitap sınıfından nesne tanımlıyoruz.
        public OduncKitapBLL()   // Constructor
        {
            oduncKitapDAL = new OduncKitapDAL();  // Üst tarafta tanımladığımız nesneyi oluşturuyoruz.
        }

        public void OduncAl(OduncKitap oduncKitap) // Ödünç kitap alma fonksiyonu
        {
            // OduncKitapDal sınıfındaki OduncAl fonksiyonuna istek yolluyor.
            // Ve OduncKitap sınıfından bir parametre alıyor.
            oduncKitapDAL.OduncAl(oduncKitap);
        }

        public void IadeEt(OduncKitap oduncKitap) // Kitap iade etme fonksiyonu
        {
            // OduncKitapDal sınıfındaki IadeEt fonksiyonuna istek yolluyor.
            // Ve OduncKitap sınıfından bir parametre alıyor.
            oduncKitapDAL.IadeEt(oduncKitap);
        }

        public DataTable OduncKitaplariSirala() // Alınan OduncKitapları Listeleme fonksiyonu
        {
            // Öncelikle DataTable türünde veri döndürür ve de parametre almaz.
            // OduncKitapDal sınıfındaki OduncKitaplarıSirala fonksiyonuna istek yollayarak olan bilgileri DataTable türünde döndürür.
            return oduncKitapDAL.OduncKitaplariSirala();
        }

    }
}
