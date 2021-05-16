using System;  // DateTime Sınıfının kullanımı için gereklidir.

namespace KutuphaneOtomasyonu.Entity
{
    public class KitapTakibi       // Kitap-Takibi Modelinin sahip olduğu özellikler
    {
        public string Ogrenci_TC { get; set; }
        public string Ogrenci_Ad { get; set; }
        public string Kitap_Serino { get; set; }
        public string Kitap_Ad { get; set; }
        public DateTime Kitap_OduncAlimTarihi { get; set; }
        public DateTime Kitap_TeslimEdilecekTarih { get; set; }
        public string Kitap_TeslimEdilenTarih { get; set; }
    }
}
