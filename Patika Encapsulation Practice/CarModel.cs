using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika_Encapsulation_Practice
{
    public class CarModel
    {
        private int _kapı;
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int Kapı // Kapı sayısı için özellik, kapsülleme uygulanmıştır
        {
            get
            {
                return _kapı;  // kapı sayısını döndür.
            }
            set
            {
                // Eğer kapı sayısı 2 veya 4 dışında bir değer ise
                if (value < 2 || value > 4)
                {
                    Console.WriteLine("Lütfen geçerli bir kapı sayısı giriniz. Kapı sayısı 2 veya 4 olmalıdır."); // hata mesajı gönder.
                    _kapı = -1; // kapı sayısını -1 yapıyoruz.
                }
                else
                {
                    _kapı = value;  // Geçerli bir değer ise kapı sayısını ata
                }
            }
        }
        // Constructor, araba nesnesini oluşturmak için kullanılır
        public CarModel(String marka, string model, string renk, int kapı)
        {
            this.Marka = marka;
            this.Model = model;
            this.Renk = renk;
            this.Kapı = kapı;
        }

        public void Yazdır() // Araba bilgilerini yazdırmak için.
        {
            Console.WriteLine($"Arabanın Markası: {Marka} || Arabanın Modeli: {Model} || Arabanın Renki : {Renk} || Kapı Sayısı: {Kapı}");
        }
    }
}
