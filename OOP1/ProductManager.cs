using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added!");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated!");
        }
        #region void area
        ////void yazmaqla int yazmaq arasindaki ferq budurki 
        ////eger geri deyer dondermeyeceyikse metodlardan buzaman voidle yaziriq
        ////geri deyer donecekse buzaman returna ehtiyac var ve voidde return yazmaq mumkun deyil
        //public int Gather(int number1, int number2)
        //{ 
        //    return number1 + number2;
        //}
        ////biz burda bildiririkki int tipinde deye donderirsen
        ////orneyi program.csde var ora bax
        //public void Gather2 (int number1, int number2)
        //{
        //    Console.WriteLine(number1 + number2);
        //}
        #endregion void area
    }
}
