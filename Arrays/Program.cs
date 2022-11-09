using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  One-Dimensional Arrays - Birolculu Massiv
            string[] students = new string [3]; //bu bir string array'dir
            students[0] = "Alyar";
            students[1] = "Omer";
            students[2] = "Deniz";

            string[] students2 = { "Deniz", "Remzi", "Metin"}; //bunu bele'de yaza bilerdik
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            foreach (var student2 in students2)
            {
                Console.WriteLine(student2);
            }
            #endregion One-Dimensional Arrays - Birolculu Massiv

            #region Multidimensional Array - Cox Olculu Massiv

            string[,] regions = new string[5, 3] // bu 5 setir 3 sutun demekdir
            {
                {"Istanbul","Izmir","Balikesir" },
                {"Ankara","Konya","Kirikkale" },
                {"antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"Izmir","Mugla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0) /*burda sifirinci dimension'in olcunun
                                                          en boyuk deyerini aliriq burda 5 0 ci dimension
                                                          setirdir 3 ise 1 ci dimension sutundur biz burda
                                                          setirin en boyuk deyerini aldiq */; i++)
            {
                //biz setirleri aldiq ama sutunlarida almaliyiq bunun ucun ic ice for edirik.
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("******************");
            }

            #endregion Multidimensional Array - Cox Olculu Massiv
            Console.ReadLine();
        }
    }
}
