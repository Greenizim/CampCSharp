using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ali", "George", "Mike", "Muhammed" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names = new string[5];
            names[4] = "Green";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
            //arrraylistin indexi biz yaratdigimiz an belirlenir ornek yuxaridaki siyahi
            //4 indexli siyahidir 4 deyer var biz buna 5 ci deyeri elave edebilmerik
            //bu sekilde new strink yazandada evvelki names memoryden silinir
            //yerine yeni names 5 indexle elave olunur ve sonuncu index'e Green deyerini menimsetmis ouruq
            //diger indexler ise bos deyer olaraq donur bize 

            /*bu sebeble proqramlasdirmada arraylerden cox az istifade olunur
            memoryde 2 erazi var biri stackk digeri ise heap
            deyer tipler ancaq stackdan istifade edir
            referans tipler ise her ikisinde
            biz burda names'e new dediyimiz anda heapde 4 deyerli bir area yaranir ve buna memoryde id menimsenir 
            misalucun 789 biz new dediyimiz anda id 800 yaranir ve 789'u yox silinir yerine 5 deyerli 4 deyeri bos sonuncusu green olan alan yaranir.

             */

            //buna gore onun yerine collections istifade olunur

            List<string> names2 = new List<string> {"Ali", "George", "Mike", "Muhammad" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Tencation");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            
        }
    }
}
