using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public virtual double KDV()
        {
            return Price * 1.08;
        }
        public Product()
        {

        }
        public Product(string name,double price)
        {
            ProductName = name;
            Price = price;
        }
    }
}
