using System;

namespace SwitchCaseStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Days Variables
            int number;
            Console.Write("Enter numbers from 1 to 7\n");
            number = Convert.ToInt16(Console.ReadLine());
            goto gtdays;
        #endregion  Days Variables

            #region Seasons Variables
            gtseasons:
            string season;
            string seasons;
            Console.Write("Please write season\n");
            season = Console.ReadLine();
            seasons = season.ToLower();
         
            goto gtend;
            #endregion Seasons Variables

            #region Days Switch
            gtdays:
            switch (number)
            {

                case 1:
                    Console.Write("Day: Monday\n");
                    break;
                case 2:
                    Console.Write("Day: Tuesday\n");
                    break;
                case 3:
                    Console.Write("Day: Wednesday\n");
                    break;
                case 4:
                    Console.Write("Day: Thursday\n");
                    break;
                case 5:
                    Console.Write("Day: Friday\n");
                    break;
                case 6:
                    Console.Write("Day: Saturday\n");
                    break;
                case 7:
                    Console.Write("Day: Sunday\n");
                    break;

            }
            goto gtseasons;
        #endregion Days Switch

            #region Seasons Switch
            gtend:
            switch (seasons)
            { 

                case "spring":
                    Console.Write("Rainy season.\n");
                    break;
                case "summer":
                    Console.Write("Sunny season.\n");
                    break;
                case "fall":
                    Console.WriteLine("The season when the trees sleep.\n");
                    break;
                case "winter":
                    Console.Write("Snowy, White season.\n");
                    break;
            }
            #endregion Seasons Switch

        }
    }
}
