using System;

namespace metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ununAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip guvenligi
            foreach (Urun urun in urunler)
            {
                Console .WriteLine(urun.Adi);
                Console .WriteLine(urun.Fiyati);    
                Console .WriteLine(urun.Aciklama);
                Console .WriteLine("-------------------");
            }
            Console.WriteLine("-------------------Metodlar_________________");
            //instance - ornek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            sepetManager.Ekle2("Armud", "Yasil armud", 4, 103);
            sepetManager.Ekle2("Alma", "Yasil alma", 2, 45);
            sepetManager.Ekle2("Qarpiz", "Sabirabad qarpizi", 1,65);
        }
    }
}
