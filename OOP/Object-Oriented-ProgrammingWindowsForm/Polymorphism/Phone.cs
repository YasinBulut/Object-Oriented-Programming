using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Phone:Product
    {
        public string Property { get; set; }
        public string Brand { get; set; }
        public Phone(string name,double price,string brand)
        {
            ProductName = name;
            Price = price;
            Brand = brand;
        }
    }
}
