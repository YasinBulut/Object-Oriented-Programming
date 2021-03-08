using CaffeDemo.Abstract;
using CaffeDemo.Adapters;
using CaffeDemo.Concrete;
using CaffeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisteme kendi gerçek bilgilerinizi girmeniz gerekli yoksa hata verir.
            BaseCustomerManager baseCustomerManager = new SturbacksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer{DateOfBirth=new DateTime(2000,11,28),FirstName="Muhammet Yasin",LastName="Bulut",NationalatyId="",Id=1 });
            Console.ReadLine();
        }
    }
}
