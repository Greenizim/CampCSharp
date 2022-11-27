using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Green
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerId = "456481";
            individualCustomer1.Name = "Green";
            individualCustomer1.Surname = "PHP";
            individualCustomer1.IdNumber = "AZE5464683L5";

            //GreenDroid
            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 2;
            corporateCustomer1.CustomerId = "827468";
            corporateCustomer1.CompanyName = "GreenDroid";
            corporateCustomer1.TaxId = "176874986765";
            //CORPORATE-INDIVIDUAL
            //SOLID

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();
            //epic pen  yukle
            //musteri classi her ikisinin referansini ozunde tuta bilir

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.Add(customer2);
            //burda mesele base sinif olan customerin her ikisinin referansini tutabilmesidir
            //inheritance tam olaraq budur
        }
    }
}
