using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreenList<string> names = new GreenList<string>();
            names.Add("Tencation");

            Console.WriteLine(names.Length);
            
            names.Add("Green");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
