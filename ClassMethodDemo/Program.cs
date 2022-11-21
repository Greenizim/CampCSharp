using System;

namespace ClassMetodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            customer1.Id = 1;
            customer2.Id = 2;
            customer3.Id = 3;
            customer1.Name = "Alyar";
            customer2.Name = "Ali";
            customer3.Name = "Omer";
            customer1.SurName = "Mammadov";
            customer2.SurName = "Omer";
            customer3.SurName = "Denizer";
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.customerAdd(customer1);
            customerManager.customerDel(customer2);
            customerManager.customerList(customers);
        }
    }
}

