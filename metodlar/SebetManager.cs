using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    internal class SebetManager
    { 
        public void Ekle(Mehsul urun)
        {
            Console.WriteLine("Sebete elave olundu --> : " + urun.Adi);
        }

        public void Ekle2(string mehsulAdi, string aciqlama, double qiymet, int stokEdedi)
        {
            Console.WriteLine("Sebete elave olundu --> : " + mehsulAdi);
        }
    }
}
