

namespace KutuphaneOtomasyonu.Entity
{
    public class Kitap     // Kitap Modelinin sahip olduğu özellikler
    {
        public string Serino { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Sayfa_Sayisi { get; set; }
        public string Yazar { get; set; }
        public string BasimTarihi { get; set; }
    }
}
