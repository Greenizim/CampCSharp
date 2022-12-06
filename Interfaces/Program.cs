
PersonManager manager = new PersonManager();
Customer customer = new Customer();
manager.Add(new Customer { Id = 1, FirstName = "Mike", LastName = "Tyson", City = "Ehmedli" });
Student student = new Student
{
    Id = 2,
    FirstName = "Smoke",
    LastName = "Reynold",
    Adress = "Ottawa" 
};
manager.Add(student);
interface IPerson // konkret obyekt
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }   
}

class Customer : IPerson//mucerred obyekt
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}

class Student : IPerson//mucerred obyekt
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}