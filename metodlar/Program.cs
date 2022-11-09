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

            Mehsul mehsul1 = new Mehsul();
            mehsul1.Adi = "Alma";
            mehsul1.Qiymeti = 15;
            mehsul1.Aciqlama = "Quba almasi";
            Mehsul mehsul2 = new Mehsul();
            mehsul2.Adi = "Banan";
            mehsul2.Qiymeti = 80;
            mehsul2.Aciqlama = "Yasil banan";

            Mehsul[] mehsullar = new Mehsul[] { mehsul1, mehsul2 };

            //type-safe -- tip tehlukesizliyi
            foreach (Mehsul mehsul in mehsullar)
            {
                Console .WriteLine(mehsul.Adi);
                Console .WriteLine(mehsul.Qiymeti);    
                Console .WriteLine(mehsul.Aciqlama);
                Console .WriteLine("-------------------");
            }
            Console.WriteLine("-------------------Metodlar_________________");
            //instance - ornek
            //encapsulation

            SebetManager sebetManager = new SebetManager();
            sebetManager.Ekle(mehsul1);
            sebetManager.Ekle(mehsul2);

            sebetManager.Ekle2("Armud", "Yasil armud", 4, 103);
            sebetManager.Ekle2("Alma", "Yasil alma", 2, 45);
            sebetManager.Ekle2("Qarpiz", "Sabirabad qarpizi", 1,65);
        }
    }
}
