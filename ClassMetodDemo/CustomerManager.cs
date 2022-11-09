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
        public void customerList(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(
                                  @$"Customer ID : {customer.Id} \n 
                                     Customer Name: {customer.Name} \n  
                                     Customer Surname: {customer.SurName} \n 
                                     ********************************"
                                 );
            }


        }
        public static void customerList(Customer customer)
        {
            Console.WriteLine("Customer" + customer.Name + " was listed");
        }
    }
}
