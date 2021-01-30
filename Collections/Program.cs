using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "murat", "ketem", "ali" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//new dedğimiz anda yeni bir adres oluşturulur. yani isimler için 5 elemanlı yeni dizi oluşturuldu.
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "engin", "murat", "ketem", "ali" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            //List bir sınıftır.
            //koleksiyonlarda da arrayler gibi değerleri kaybetmemizi engeleyecek bir altyapı var
           
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]); 
            Console.WriteLine(isimler2[0]);

        }
    }
}
