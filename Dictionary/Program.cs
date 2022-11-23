//dictionary list key nomrelerine gore daha tez listeleyir

MainClass mainClass = new MainClass();
mainClass.MainStart();

public class Human
{
    public string Name;
}

public class MainClass
{ 
    Dictionary<int,string> keyValuePairs= new Dictionary<int,string>(); //burda int keyvalue tipidir string ise deyer

    Dictionary<int,Human> humanList= new Dictionary<int,Human>();
    public void MainStart()
    {
        keyValuePairs.Add(1, "Ali");
        keyValuePairs.Add(12, "Mike");
        keyValuePairs.Add(3, "George");
        keyValuePairs.Add(4, "Omer");

        humanList.Add(1, new Human() { Name = "Muhammet" });
        humanList.Add(2, new Human() { Name = "Tencation" });
        humanList.Add(3, new Human() { Name = "Snoop Dogg" });
        humanList.Add(4, new Human() { Name = "Tupac" });

        Console.WriteLine(keyValuePairs[12]);
        Console.WriteLine(SearchList(3));
        Console.WriteLine(SearchList(5));

        Console.WriteLine(SearchHuman(2).Name);//budefe burda name'ini yazdirabildik
        Console.WriteLine(SearchHuman(5).Name);
        if (keyValuePairs.ContainsKey(1))
        {
            Console.WriteLine("Item Found! -> " + keyValuePairs[1]);
        }
        else 
        {
            Console.WriteLine("Item Not Found!");
        }
    }

    public string SearchList(int searching)
    {
        string outputValue;
        Human outValue;
        if (keyValuePairs.TryGetValue(searching, out outputValue))//bu demekdirki eger listin icinde taparsan deyeri geri at
        {
            return outputValue;
        }
        else 
        {
            return "This Item Is Not In The List!";
        }

    }

    public Human SearchHuman(int searching)
    {
        Human outValue = new Human() { Name = "Name Not Found!" /*burda nullarda yeni default donus deyerini  bildirik*/ }; //budefe burda null deyerde yanlis key valuede problem yasamamaq ucun newleyirik
        if (humanList.ContainsKey(searching))
        {
            if (humanList.TryGetValue(searching, out outValue))
            {
                return outValue;
            }
        }
        else
        {
            /* return null;*/ //burda ise nulll dedik cunki string ifade dondurebilmirik.
                              //yene null problemi yasamamaq ucun return'u donen deyer- outvalue edirik ve null yox bos deyer donmus olur

            return outValue;
        }
        return outValue;
    }
}