using System;

namespace KutuphaneUygulamasi
{
    public class Kitap
    {
        // Kitap özellikleri
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayınevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        // Default Constructor
        public Kitap()
        {
            Console.WriteLine("Bir kitap kaydedildi.");
            KayitTarihi = DateTime.Now; // Kayıt tarihi şu an olarak atanır
        }

        // Parametreli Constructor
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            Console.WriteLine("Bir kitap kaydedildi.");
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayınevi = yayinevi;
            KayitTarihi = DateTime.Now; // Kayıt tarihi şu an olarak atanır
        }

        // Bilgileri yazdıran metot
        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Yazar: {YazarAdi} {YazarSoyadi}, Sayfa Sayısı: {SayfaSayisi}, Yayınevi: {Yayınevi}, Kayıt Tarihi: {KayitTarihi.ToShortDateString()}");
        }
    }
}
