using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    internal class CustomerManager
    {
        public static void customerAdd(Customer customer)
        {
            Console.WriteLine("Customer" + customer.Name + " was added");
        }
        public static void customerDel(Customer customer)
        {
            Console.WriteLine("Customer" + customer.Name + " was deleted");
        }

    }
}
