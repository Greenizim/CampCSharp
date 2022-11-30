using OOP3;
using System.Collections.Generic;
#region Abstraction
//PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
//personalFinanceCreditManager.Calculate();

//VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
//vehicleCreditManager.Calculate();

//MortageCreditManager mortageCreditManager = new MortageCreditManager();
//mortageCreditManager.Calculate();

ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

ICreditManager vehicleCreditManager = new VehicleCreditManager();

ICreditManager mortageCreditManager = new MortageCreditManager();

//burani ekran olaraq dusunek ordan 3 kreditden birini secir
//interface'lerde o interface'i implement eden class'in referans nomresini tuta bilir.
//polymorphism

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.MakeAnApplication(personalFinanceCreditManager);//burani button olaraq dusunek burdan birini adam secir buttona basanda bu emeliyyat icra olur parametr olaraq onu gonderir
#endregion Abstraction
Console.WriteLine("------------------------------------");
List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, mortageCreditManager };
applicationManager.MakeALoanPreInformation(credits);