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

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService= new FileLoggerService();
ICreditManager businessCreditManager = new BusinessCreditManager();
ILoggerService smsLoggerService = new SmsLoggerService();
List<ICreditManager> creditsManager =  new List<ICreditManager>() { businessCreditManager, personalFinanceCreditManager};
List<ILoggerService> loggersService = new List<ILoggerService>() { databaseLoggerService, smsLoggerService };

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.MakeAnApplication(creditsManager, loggersService);//burani button olaraq dusunek burdan birini adam secir buttona basanda bu emeliyyat icra olur parametr olaraq onu gonderir
Console.WriteLine("------------------------------------");

#endregion Abstraction

//List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, mortageCreditManager };
//applicationManager.MakeALoanPreInformation(credits);