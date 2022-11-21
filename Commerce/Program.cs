using System;

namespace E_Commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Product List

            Products product1 = new Products();
            Products product2 = new Products();
            Products product3 = new Products();

            product1.id = 1;
            product1.name = "KLACID  SR  500mg  N5 ";
            product1.productionDate = Convert.ToDateTime("15.11.2022");
            product1.expirationDate = Convert.ToDateTime("15.11.2025");
            product1.price = 11.46;

            product2.id = 2;
            product2.name = "ROGAM  300mg qotov. spr.  N1";
            product2.productionDate = Convert.ToDateTime("15.11.2022");
            product2.expirationDate = Convert.ToDateTime("15.11.2024");
            product2.price = 149.42;

            product3.id = 3;
            product3.name = "METOPROLOL 50mg N40 ";
            product3.productionDate = Convert.ToDateTime("15.11.2022");
            product3.expirationDate = Convert.ToDateTime("15.11.2027");
            product3.price = 3.45;

            Products[] products = new Products[] { product1, product2, product3 };

            #endregion Product List

            #region For
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ID: " + products[i].id +
                                  "\nName: " +products[i].name +
                                  "\nProduction date: " + products[i].productionDate + 
                                  "\nExpiration date: " + products[i].expirationDate + 
                                  "\nPrice: " + products[i].price);
            }
            Console.WriteLine("****************************************************************************");

            #endregion For

            #region Foreach
            foreach (var prod in products)
            {
                Console.WriteLine("ID -> " + prod.id + 
                                  "\nName -> " +prod.name +
                                  "\nProduction date -> " + prod.productionDate +
                                  "\nExpiration date -> " + prod.expirationDate +
                                  "\nPrice -> " + prod.price);
            }
            Console.WriteLine("****************************************************************************");

            #endregion Foreach

            #region While
            int j = 0;

            while (j < products.Length)
            {
                Console.WriteLine("ID => " + products[j].id + 
                                  "\nName => " + products[j].name + 
                                  "\nProduction date => " +products[j].productionDate + 
                                  "\nExpiration date => " + products[j].expirationDate + 
                                  "Price => " + products[j].price);
                j++;
            }
            Console.WriteLine("****************************************************************************");
            #endregion While
        }
    }
}

