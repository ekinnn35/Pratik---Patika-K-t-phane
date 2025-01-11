using System;
using KutuphaneUygulamasi;

namespace KutuphaneUygulamasiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default constructor ile nesne oluşturma
            Kitap kitap1 = new Kitap
            {
                Ad = "Bir Kitap",
                YazarAdi = "Ahmet",
                YazarSoyadi = "Yılmaz",
                SayfaSayisi = 320,
                Yayınevi = "Alfa Yayınları"
            };

            // Parametreli constructor ile nesne oluşturma
            Kitap kitap2 = new Kitap("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayıncılık");

            // Diğer kitaplar
            Kitap kitap3 = new Kitap("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gamma Yayınları");
            Kitap kitap4 = new Kitap("Son Kitap", "Elif", "Şahin", 275, "Delta Yayınları");
            Kitap kitap5 = new Kitap("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");

            // Kitap bilgilerini yazdırma
            kitap1.BilgiYazdir();
            kitap2.BilgiYazdir();
            kitap3.BilgiYazdir();
            kitap4.BilgiYazdir();
            kitap5.BilgiYazdir();

            Console.ReadKey(); // Konsolu açık tutar
        }
    }
}
