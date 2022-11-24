using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Governments
{
  public class Governments<TKey,TValue>
    {
        KeyValuePair<TKey, TValue>[] _items;
       
        public Governments()
        {
            _items = new KeyValuePair<TKey, TValue>[0];
        }
        public void Add(TKey item1,TValue item2)
        {
            KeyValuePair<TKey, TValue>[] _tempItems = _items;
            _items = new KeyValuePair<TKey, TValue>[_items.Length + 1];
            for (int i = 0; i < _tempItems.Length; i++)
            {
                _items[i] = _tempItems[i];
            }
            _items[_items.Length - 1] = new KeyValuePair<TKey, TValue>(item1, item2);
        }
        public int Count
        {
            get { return _items.Length; }
        }
     
    }
}
