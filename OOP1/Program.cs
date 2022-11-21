using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Product Area
            Product product1 = new Product(); //bunlar adice integer veya string kimi deyisendi
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.ProductName = "Stol";
            product1.UnitPrice = 63;
            product1.UnitsInStock = 72;


            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock =5, ProductName = "Defter", UnitPrice = 0.6};
            //PascalCase - classlarda kelimelerin ilk herfi boyukolmalidi
            //camelCase claas deyisen adlarinda ilk kelimenin herfi kicik olmalidi
            //case sensitive

            //string , ind , double......... bunlar deger tipleridi
            //arrays, interface abstract class class.....  referans tipdir
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            #endregion Product Area

            #region Void Area
            //productManager.Gather(7, 21);

            //int totalResult = productManager.Gather2(7, 21); 
            #endregion Void Area
        }
    }
}
