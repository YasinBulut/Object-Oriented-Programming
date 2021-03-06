using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Delete();
            customerManager.Update();
            Console.WriteLine("************");
            ProductManager productManager = new ProductManager();
            productManager.Update();
            productManager.Add();
            productManager.Delete();
            Console.WriteLine("************");
            Customer customer = new Customer()
            {
                CustomerName = "Yasin",
                CustomerId = 1,
                City = "İstanbul",
                Mail = "yasin@outlook.com",
                TelNumber = "05417664110"
            };
            Console.WriteLine("Name:"+customer.CustomerName +"\nID:"+customer.CustomerId + "\nŞehir:" + customer.City+ "\nMail:" + customer.Mail+ "\nTelefon Numarası:" + customer.TelNumber);
            Console.WriteLine("************");
            Category category = new Category()
            {
                CategoryID = 1,
                CatgoryName="Elektronik Aletler"
            };
            Console.WriteLine(category.CategoryID+"\n"+category.CatgoryName);
            Console.WriteLine("************");
            Product product = new Product()
            {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Telefon",
                UnitPrice = "4500",
                UnitIsInStock = "15"
            };
            Console.WriteLine(product.ProductId+"\n"+product.CategoryId+"\n"+product.ProductName+"\n"+product.UnitPrice+"\n"+product.UnitIsInStock);
            Console.WriteLine("************");
            Console.ReadLine();
        }
    }
}
