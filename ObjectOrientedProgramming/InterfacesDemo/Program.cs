using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2] 
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void GetSalary()
        {
            Console.WriteLine("Maaş Verildi");
        }

        public void Work()
        {
            Console.WriteLine("Çalışılıyor...");
        }

        void IEat.Eat()
        {
            Console.WriteLine("Yemek Molası");
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Yemek Molası");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş Verildi");
        }

        public void Work()
        {
            Console.WriteLine("Çalışılıyor...");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalışılıyor...");
        }
    }
}
