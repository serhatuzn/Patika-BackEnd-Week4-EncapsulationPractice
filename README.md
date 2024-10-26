# 🚗 Patika - Encapsulation Projesi

Bu proje, OOP (Nesne Yönelimli Programlama) prensiplerinden biri olan kapsüllemeyi (encapsulation) kullanarak bir Araba sınıfı oluşturmayı amaçlamaktadır.

## 📋 Proje Açıklaması

Bu örnekte, `CarModel` isimli bir sınıf oluşturulmuştur. Sınıf, aşağıdaki özellikleri içermektedir:

- **Marka**: Arabanın markası.
- **Model**: Arabanın modeli.
- **Renk**: Arabanın rengi.
- **Kapı Sayısı**: Arabanın kapı sayısı.

Kapı sayısı için kapsülleme işlemi yapılmıştır. Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse, konsol ekranında bir uyarı mesajı yayınlanmakta ve Kapı Sayısı değeri -1 olarak ayarlanmaktadır.

## 🛠️ Gereksinimler

- .NET Framework veya .NET Core
- C# dili

## 📦 Kullanım

1. Projeyi indirin veya klonlayın.
2. Visual Studio veya herhangi bir C# IDE'si ile projeyi açın.
3. `CarModel` sınıfından bir nesne oluşturun ve kapı sayısını belirleyin.

### Örnek Kullanım

Aşağıda, `CarModel` sınıfının nasıl kullanılacağına dair bir örnek verilmiştir:

```csharp
using System;

namespace Patika_Encapsulation_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Geçerli kapı sayısı
            CarModel araba1 = new CarModel("Toyota", "Corolla", "Kırmızı", 4);
            araba1.Yazdır();

            // Geçersiz kapı sayısı
            CarModel araba2 = new CarModel("Ford", "Fiesta", "Mavi", 3); // Hata mesajı verecek
            araba2.Yazdır();
        }
    }
}
