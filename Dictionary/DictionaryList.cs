using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dictionary
{
    internal class DictionaryList <TKey,TValue>
    {
        KeyValuePair<TKey, TValue>[] _items;
        KeyValuePair<TKey, TValue>[] _tempItems;
        public DictionaryList()
        {
            _items = new KeyValuePair<TKey, TValue>[0];
        }
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            _tempItems = _items;
            _items = new KeyValuePair<TKey, TValue>[_items.Length + 1];
            for (int i = 0; i < _tempItems.Length; i++)
            {
                _items[i] = _tempItems[i];
            }
            _items[_items.Length - 1] = item;
        }
        public int Count
        {
            get { return _items.Length; }
        }
    }
}
