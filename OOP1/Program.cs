﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, 
                ProductName = "kalem ", UnitPrice = 35 };

            //ProductManagerdaki productManager yeni bir referans numarası almış ProductMangerdır.
            //PascalCase    //camelCase
            //casw sensitive
            //productmanager türünde string(productmanager) türürnde isim
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2);


            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);

            //int,double,bool... değer tip
            //diziler,class.abstract class, interface .... referans tip
        }
    }
}
