using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet code prop
    internal class Product
    {
        public int Id { get; set; }
        //ilk siraya herzaman id ikinci siraya ise foreign key'ler (ikinci v.s id'ler) yazilmalidir
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //bir e ticaret sisteminde mesulu listelenir elave edilir veya guncellenir
        // bu operasyonlara CRUD (Create Read Update Delete) operasyonu deyilir.
  
    }
}
