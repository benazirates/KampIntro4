using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
             
            MyList<string> names = new MyList<string>();
            
            names.Add("engin");
            Console.WriteLine(names.Lenght);
           
            names.Add("kerem");
            Console.WriteLine(names.Lenght);
            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }


        }
    }
}
