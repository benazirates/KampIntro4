using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        // string[] items;
        T[] items;

        //constructor bir class newlendiğinde çalışan bloğa denir.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {

            T[] tempArray = items;
            items = new T[items.Length + 1];//dizinin eleman sayısını verir
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
        //item=eleman
        public int Lenght
        {
            get { return items.Length; }//eleman sayısısını verir
        }
        public T[] Items
        {
            get { return items; }
        }







    }






}    

   

   




    
  
