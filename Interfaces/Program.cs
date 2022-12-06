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