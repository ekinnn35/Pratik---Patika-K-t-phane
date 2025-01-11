# Patika Kütüphane Uygulaması

Bu proje, bir kitap kayıt uygulaması oluşturmak için hazırlanmıştır. Projede kitap nesneleri, "Ad", "Yazar Adı", "Yazar Soyadı", "Sayfa Sayısı", "Yayınevi" ve "Kayıt Tarihi" gibi özelliklerle tanımlanmıştır.

## Amaç

Bu uygulama, constructor (özel yapıcı metotlar) ve nesne tabanlı programlama (OOP) konseptlerini anlamak ve pratik yapmak için tasarlanmıştır.

## Proje Yapısı

Proje, iki ana dosyadan oluşmaktadır:

### 1. `Kitap.cs`
Bu dosya, "Kitap" sınıfını ve constructor'ı tanımlar.

#### **Kitap Sınıfı: Property'ler**
- **Ad**: Kitabın adı.
- **YazarAdi**: Yazarın adı.
- **YazarSoyadi**: Yazarın soyadı.
- **SayfaSayisi**: Kitabın sayfa sayısı.
- **Yayınevi**: Kitabın yayınevi.
- **KayitTarihi**: Kitap kayıt tarihini saklar.

#### **Kitap Sınıfı: Constructor'ır**
- **Default Constructor**: Parametre almaz ve "Bir kitap kaydedildi." mesajını konsola yazdırır. Kayıt tarihini otomatik olarak şu anki tarih yapar.
- **Parametreli Constructor**: Kitap adı, yazar adı, soyadı, sayfa sayısı ve yayınevi bilgilerini alır ve ilgili property'lere atar.

#### **Metotlar**
- `BilgiYazdir()`: Kitap nesnesinin tüm bilgilerini konsola yazdırır.

---

### 2. `Program.cs`
Bu dosya, "Kitap" sınıfını kullanarak kitap nesneleri oluşturur ve bu nesnelerin bilgilerini konsola yazdırır.

#### **Ana Adımlar**
1. **Default Constructor Kullanımı**:
   - Kitap nesnesi oluşturulur ve property'leri elle atanır.
2. **Parametreli Constructor Kullanımı**:
   - Tüm property'ler constructor parametreleri ile atanır.
3. **Bilgileri Yazdırma**:
   - `BilgiYazdir()` metodu ile kitap bilgileri konsola yazdırılır.

---

## Nasıl Kullanılır?

1. **Proje Dizini:**
   - Solution Explorer'da iki ayrı dosya olacak:
     - `Kitap.cs` (Sınıf tanımı)
     - `Program.cs` (Ana program)

2. **Kitap Nesneleri Oluşturma:**
   - İlgili property'lere değerler atayarak kitap nesneleri tanımlanır.

3. **Kodu Çalıştırma:**
   - Proje çalıştırıldığında kitap bilgileri ve kayıt mesajları konsola yazdırılır.

---

## Örnek Çıktı
```
Bir kitap kaydedildi.
Bir kitap kaydedildi.
Bir kitap kaydedildi.
Bir kitap kaydedildi.
Bir kitap kaydedildi.
Ad: Bir Kitap, Yazar: Ahmet Yılmaz, Sayfa Sayısı: 320, Yayınevi: Alfa Yayınları, Kayıt Tarihi: [O anki tarih]
Ad: Başka Bir Kitap, Yazar: Ayşe Karan, Sayfa Sayısı: 215, Yayınevi: Beta Yayıncılık, Kayıt Tarihi: [O anki tarih]
Ad: Daha Başka Kitap, Yazar: Mehmet Demir, Sayfa Sayısı: 450, Yayınevi: Gamma Yayınları, Kayıt Tarihi: [O anki tarih]
Ad: Son Kitap, Yazar: Elif Şahin, Sayfa Sayısı: 275, Yayınevi: Delta Yayınları, Kayıt Tarihi: [O anki tarih]
Ad: Örnek Kitap, Yazar: Selin Yurt, Sayfa Sayısı: 198, Yayınevi: Epsilon Yayınları, Kayıt Tarihi: [O anki tarih]
```

---

## Kavramlar
- **Class**: Sınıflar, nesne tabanlı programlamanın temel yapı tasarımlarıdır. "Kitap" bir sınıftır.
- **Property**: Nesnelerin (örneğin "Kitap") özelliklerini tanımlar.
- **Constructor**: Nesneler oluşturulurken çalışan özel metotlardır. Bu projede default ve parametreli constructor kullanılmıştır.
- **Method**: Nesneye ait işlevleri tanımlar. "BilgiYazdir()" bir metottur.

---


