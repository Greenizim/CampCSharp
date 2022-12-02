
#region Classes

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

#endregion Classes

#region Property In Customer

Customer customer2 = new Customer { Id = 1, FirstName = "George", LastName = "Reynold", City = "Tbilisi" };

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.FirstName = "Mike";
customer1.LastName = "Tyson";
customer1.City = "Ottowa";
Console.WriteLine(customer2.LastName);

#endregion Property In Customer
