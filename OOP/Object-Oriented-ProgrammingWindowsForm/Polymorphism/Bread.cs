using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Bread:Product
    {
        public string Kind { get; set; }
        public int Gram { get; set; }
        public override double KDV()
        {
            return Price * 1.01;
        }
        public Bread(string name,double price,string kind,int gram)
        {
            ProductName = name;
            Price = price;
            Kind = kind;
            Gram = gram;
        }

    }
}
