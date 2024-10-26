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
        public int Kapı
        {
            get
            {
                return _kapı;
            }
            set
            {
                if (value < 2 || value > 4)
                {
                    Console.WriteLine("Lütfen geçerli bir kapı sayısı giriniz. Kapı sayısı 2 veya 4 olmalıdır.");
                    _kapı = -1;
                }
                else
                {
                    _kapı = value;
                }
            }
        }

        public CarModel(String marka, string model, string renk, int kapı)
        {
            this.Marka = marka;
            this.Model = model;
            this.Renk = renk;
            this.Kapı = kapı;
        }

        public void Yazdır()
        {
            Console.WriteLine($"Arabanın Markası: {Marka} || Arabanın Modeli: {Model} || Arabanın Renki : {Renk} || Kapı Sayısı: {Kapı}");
        }
    }
}