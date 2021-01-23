using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//myListimde T değerinde çalışacağım.tipe karşılık geliraşağıda ne belirtilirse o türde çalışılır.
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];


        }
        public void Add(T item)   //item...eleman. istenilen bir isim verilebilir
        {
            T[] tempArray = items;   //geçici dizin
            items = new T[items.Length + 1];


        }

    }
}
