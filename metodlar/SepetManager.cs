using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    internal class SepetManager
    { 
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sebete elave olundu --> : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokEdedi)
        {
            Console.WriteLine("Sebete elave olundu --> : " + urunAdi);
        }
    }
}
