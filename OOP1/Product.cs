using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{  //bu tip klaslarda sadece özellik yer alır.
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}    //CRUD operasyonları(creat run update delete)
