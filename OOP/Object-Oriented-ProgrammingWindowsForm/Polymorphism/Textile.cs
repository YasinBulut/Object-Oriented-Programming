using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Textile :Product
    {
        public string Fabric { get; set; }
        public int BodySize { get; set; }
        public string Company { get; set; }
        public Textile(string name,double price,string fabric,int bodysize,string company)
        {
            ProductName = name;
            Price = price;
            Fabric = fabric;
            BodySize = bodysize;
            Company = company;
        }
    }
}
