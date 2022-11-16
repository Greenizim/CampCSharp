using System;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else Logic
            bool maritalStat = true;
            string mess;
            if (maritalStat == true)
            {
                mess = "Married";
            }
            else
            {
                mess = "Single";
            }
           //buqeder kod yazmaq ne derecede dogrudur?
           //sanki luzumsuzdur bu kimi veziyyetlerde ternary operatorundan istifade olunur.
            #endregion If-Else Logic

            #region Ternary Operator
            bool maritalStatus = true;
            string message = maritalStatus == true ? "Married" : "Single";
            Console.WriteLine(message);
            //Diqqet!
            //Ternary Operatoruna true ve false deyeri olaraq eyni tipde deyer
            //verilmelidir string veya int olmaz, eyni tipde olmalidir.
            #endregion Ternary Operator

            #region Multi Condition Ternary Operator
            //İstifadeci terefinden girilen deyer 
            //asagidaki teleblere cavab vermelidir
            // reqem < 3                            =reqem * 5
            // reqem > 3 && reqem <9        =       =reqem * 3
            // reqem >= 9 && reqem % 2 == 0         =reqem * 10
            // reqem % 2 ==1                        =reqem
            //hecbiri deyilse                       =-1
            Console.WriteLine("Please enter a number!");
            int number = int.Parse(Console.ReadLine());
            int result = number < 3 ? number * 5 :
                number > 3 && number < 9 ? number * 3 :
                number >= 9 && number % 2 == 0 ? number * 10 :
                number % 2 == 1 ? number : -1;
            Console.WriteLine("Result => " + result);
            # endregion Multi Condition Ternary Operator
        }
    }
}
