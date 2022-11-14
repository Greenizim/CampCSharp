using System;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number less than 1000 and I will count for you");
            number = Convert.ToInt16(Console.ReadLine());
            while(number<=10000 )
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}
