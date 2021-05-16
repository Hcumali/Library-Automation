using System;  // DateTime Sınıfının kullanımı için gereklidir.

namespace KutuphaneOtomasyonu.Entity
{
    public class OduncKitap    // Odunc-Kitap Modelinin sahip olduğu özellikler
    {
        public string KitabıAlanOgrenci_Tcno { get; set; }
        public string VerilenKitabin_SeriNo { get; set; }
        public string VerilenKitabin_Ad { get; set; }
        public DateTime Kitap_AlimTarihi { get; set; }
        public DateTime Kitap_TeslimTarihi { get; set; }

    }
}
