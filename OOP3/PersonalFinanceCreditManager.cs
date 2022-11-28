using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance credit payment schedule calculated");
        }

        public void Example()
        {
            throw new NotImplementedException();
        }
    }
}
