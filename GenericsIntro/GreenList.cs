using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class GreenList <T>
    {
        T[] items; // genericler hansi tipde isleyirikse onu goturur
        // bu ctor constuctor du clasi new ledikde avtomatik baslangicda isleyir
        public GreenList()
        {
            items = new T[0];
        }
        // bir class isleyende calisan bloka konstaktor deyilir
        public void Add(T item)
        {
            //newledikde deyerler ititr bunun qarsisini almaq ucun temponary list yaradiriq
            T[] tempArray = items;
            //cunki newlwediyimiz an o referans nomresini buraxir yeni referans nomresi alir;
            items = new T[items.Length + 1]; //arrayin elemanlarini 1 eded artirir
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length -1] = item;

        }
    }
}
