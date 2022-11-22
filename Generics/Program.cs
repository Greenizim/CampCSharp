List<string> cits = new List<string>();
cits.Add("Baku");
cits.Add("Baku");
cits.Add("Baku");
cits.Add("Baku");
Console.WriteLine(cits.Count);
MyList<string> citys2 = new MyList<string>();
citys2.Add("Baku");
citys2.Add("Baku");
citys2.Add("Baku");
Console.WriteLine(citys2.Count);
#region Generic Class
class MyList<T>//Generic class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array= new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1]=item;
    }
    
    //propfull
    public int Count
    {
        get { return _array.Length; }
    }
}
#endregion Generic Class