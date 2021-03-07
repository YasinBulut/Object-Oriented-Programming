using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Basket
    {
        private List<Product> products = new List<Product>();
        public double TotalPrice()
        {
            double totalprice = 0;
            foreach (var product in products)
            {
                totalprice += product.KDV();
            }
            return totalprice;
        }
        public void ProdutAdd(Product newproduct)
        {
            products.Add(newproduct);
        }
    }
}
