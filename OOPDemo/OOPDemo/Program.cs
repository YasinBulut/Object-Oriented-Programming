using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new IsBankServiceAdapter());
            //IProductService productService = new ProductManager(new CentralBankServiceAdapter());
            //IProductService productService = new ProductManager(new FakeBankService());
            //productService.Sell(new Product {Id=1,Name="Leptop",Price=1000 },new Student {Id=1,Name="Yasin" });
            productService.Sell(new Product { Id = 1, Name = "Leptop", Price = 1000 }, new Officer { Id = 1, Name = "Yasin" });
        }
    }
    //***********************
    interface IEntity
    {

    }

    class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStuent { get; set; }
    }
    class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    //*************************
    class ProductManager : IProductService
    {
        private IBankService _bankService;

        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void Sell(Product product, ICustomer customer)
        {
            decimal price = product.Price;
            price = customer.GetPrice(price);
            price = _bankService.ConvertRate(new CurrencyRate() { Currency = 1, Price = price });
            Console.WriteLine(price);
            Console.ReadLine();
        }
    }
    interface IProductService
    {
        void Sell(Product product, ICustomer customer);
    }
    interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }
    class CurrencyRate
    {
        public decimal Price { get; set; }
        public int Currency { get; set; }
    }
    //Banka Operasyonlarını adapte etme
    class CentralBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankService centralBankService = new CentralBankService();
            return centralBankService.ConvertCurrency(currencyRate);
        }
    }
    class IsBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            IsBankService ısBankService = new IsBankService();
            return ısBankService.ConvertCurrency(currencyRate);
        }
    }
    //Fake deneme banka kodu
    class FakeBankService : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)7.50;
        }
    }
    //Merkez bankası kodu  -- Değiştirilemez o yüzden adapte işlemi yapıldı
    class CentralBankService
    {
        public decimal ConvertCurrency(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)7.45;
        }
    }
    //İş Bankası kodu -- Değiştirilemez o yüzden adapte işlemi yapıldı
    class IsBankService
    {
        public decimal ConvertCurrency(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)7.95;
        }
    }

    //Müşteri Fiyatlandırma
    interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal GetPrice(decimal price);
    }

    class Officer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal GetPrice(decimal price)
        {
            return price * (decimal)0.80;
        }
    }

    class Student : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal GetPrice(decimal price)
        {
            return price * (decimal)0.90;
        }
    }


}
