using OOP3;

//PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
//personalFinanceCreditManager.Calculate();

//VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
//vehicleCreditManager.Calculate();

//MortageCreditManager mortageCreditManager = new MortageCreditManager();
//mortageCreditManager.Calculate();


ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
personalFinanceCreditManager.Calculate();

ICreditManager vehicleCreditManager = new VehicleCreditManager();
vehicleCreditManager.Calculate();

ICreditManager mortageCreditManager = new MortageCreditManager();
mortageCreditManager.Calculate();

//interface'lerde o interface'i implement eden class'in referans nomresini tuta bilir.
//polymorphism

