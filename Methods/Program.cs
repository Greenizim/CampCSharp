using System;

namespace metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mehsulAdi = "Elma";
            double qiymeti = 15;
            string aciqlama = "Qirmizi alma";

            Product mehsul1 = new Product();
            mehsul1.Adi = "Alma";
            mehsul1.Qiymeti = 15;
            mehsul1.Aciqlama = "Quba almasi";
            Product mehsul2 = new Product();
            mehsul2.Adi = "Banan";
            mehsul2.Qiymeti = 80;
            mehsul2.Aciqlama = "Yasil banan";

            Product[] mehsullar = new Product[] { mehsul1, mehsul2 };

            //type-safe -- tip tehlukesizliyi
            foreach (Product mehsul in mehsullar)
            {
                Console .WriteLine(mehsul.Adi);
                Console .WriteLine(mehsul.Qiymeti);    
                Console .WriteLine(mehsul.Aciqlama);
                Console .WriteLine("-------------------");
            }
            Console.WriteLine("-------------------Metodlar_________________");
            //instance - ornek
            //encapsulation

            CartManager sebetManager = new CartManager();
            sebetManager.Ekle(mehsul1);
            sebetManager.Ekle(mehsul2);

            sebetManager.Ekle2("Armud", "Yasil armud", 4, 103);
            sebetManager.Ekle2("Alma", "Yasil alma", 2, 45);
            sebetManager.Ekle2("Qarpiz", "Sabirabad qarpizi", 1,65);
        }
    }
}
