using System;  // DateTime Sınıfının kullanımı için gereklidir.

namespace KutuphaneOtomasyonu.Entity
{
    public class Ogrenci   // Öğrenci Modelinin sahip olduğu özellikler
    {
        public string Tcno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telno { get; set; }
        public string Meslek { get; set; }
        public DateTime Kayit_Tarihi { get; set; }
    }
}
