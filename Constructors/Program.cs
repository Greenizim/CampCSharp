    #region Console
    //constructor bir classi new'lediyimizde isleyen blokdur
    //bir klass ilk defe isleyende bir defe calisar ve birdaha calismaz
    Customer customer1 = new Customer { Id = 1, FirstName = "Ali", LastName = "Mammadov", City = "Ottawa" }; // bunu belede yaza bilerdik

    Customer customer2 = new Customer(2, "George", "Reynold", "Ankara"); // normal moterize gorurukse demek burda bir metod mentiqi var bunlar bir parametrdir
    //eger biz bunu customer 1 kimi yox ikide yazdigimiz kimi isletmek isteyirikse ozaman setr 18 e bax

    Console.WriteLine(customer2.FirstName);
    #endregion Console

    #region Method
    Method(3, "Duman", "Denizer", "Ankara");
    static void Method (int id, string firstName, string lastName, string city)
    { 
        //gorduyun kimi bu bir metoddur konstruktorlarda metod mentiqi ile islediyi ucun onlara parametrler vermek mumkundur
    }
#endregion Method

    #region Default Constructor
class Customer
{

    //ctorbu constructordu butun classlarda biz yaratmasaqda default constructor olur!
    #endregion

    #region Method Overloading
    public Customer()
    {
        //ve parametr vermediyimiz ucun budefe burda customer 1 parametr vermiyimizde ise customer2 isleyeecek bu hemde birnov method overloadingdir
    }
    #endregion Method Overloading

    #region Constructor
    public Customer(int id, string firstName, string lastName, string city)
    {
        //Console.WriteLine("Konstruktor isledi!");
        //indi parametrler veririk
        //constructor yazdiq ve belelikle default constructoru ezmis olduq
        Id= id;
        FirstName= firstName;
        LastName= lastName;
        City= city;
        //geri deyer dondurebilmek, oxuyabilmek ucunse deyerleri beraberlesdiririk.
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    //bu xususiyyet saxlayan class növüdü
    //bunun emeliyyat icra eden class novude var select delete list update filter v.s

}
#endregion Constructor
