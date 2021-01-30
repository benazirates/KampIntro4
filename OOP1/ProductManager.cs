using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {   //encapsulation
        public void Add(Product product)//bana ürün türünde bişey ver//101
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
         
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        //void emir kipinde git demek örn gir ekle git sil git güncelle 
        //voidde return yoktur.yani örn toplanan sayiyi 2 ile çarpıp ekrana yazdırmak istiyoruz o yüzden int yazmalıyız ki return olsun.

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
