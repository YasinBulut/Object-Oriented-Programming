using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Product
    {
        //Property
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string UnitIsInStock { get; set; }
    }
}
