using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class CartManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sebete elave olundu --> : " + urun.Adi);
        }

        public void Ekle2(string mehsulAdi, string aciqlama, double qiymet, int stokEdedi)
        {
            Console.WriteLine("Sebete elave olundu --> : " + mehsulAdi);
        }

    }
}
