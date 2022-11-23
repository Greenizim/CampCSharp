    #region Program
//dictionary list key nomrelerine gore daha tez listeleyir
//using System.Collections.Generic;

//System.Collections.Generic sınıfının altında yer alan Generic Dictionary<> yapısı; eklenen elemanların Key ve Value olarak kayıt edilmesini sağlamaktadır.
//using System.ComponentModel.Design;
//Dictionary sınıfı içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklar bu durumun bir zorunluluğu var
//Key türünü belirlemeniz şarttır (string,int,decimal,float...)
//bu şekilde değerlere ekle , silme, saydırma işlemleri atayabiliriz

MainClass mainClass = new MainClass();
mainClass.MainStart();
#endregion Program

    #region Class
public class Human
{
    public string Name;
}
#endregion Class

    #region Dictionary Lists
public class MainClass
{
    Dictionary<int, string> keyValuePairs = new Dictionary<int, string>(); //burda int keyvalue tipidir string ise deyer
    Dictionary<int, Dictionary<int, string>> DicList = new Dictionary<int, Dictionary<int, string>>(); // donecek deyer dictionary sinifdir 
    Dictionary<int, List<Human>> HumanList = new Dictionary<int, List<Human>>();// heta burda donecek deyer listdide deye bilerik
    Dictionary<int, Human> humanList = new Dictionary<int, Human>();

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
    #endregion Dictionary Lists

    #region Methods
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
    #endregion Methods
