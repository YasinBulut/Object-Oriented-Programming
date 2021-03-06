using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerDal()
            };
            foreach (var customerdal in customerDals)
            {
                customerdal.Add();
                Console.WriteLine("******");
                customerdal.Update();
                Console.WriteLine("******");
                customerdal.Delete();
                Console.WriteLine("******");
            }



            Console.ReadLine();
        }
        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                ID = 1,
                FirstName = "YASİN",
                LastName = "BULUT",
                Departmen = "JUNİOR DEVELOPER"
            };
            Student student = new Student
            {
                ID = 1,
                FirstName = "MELİKE",
                LastName = "YENTÜR",
                Adress = "KARABÜK"
            };
            Worker worker = new Worker
            {
                ID = 1,
                FirstName = "BEYZA",
                LastName = "EREN",
                Departmen = "ENGİNEER",
            };
            Robot robot = new Robot
            {
                ID = 1,
                FirstName = "EREN",
                LastName = "CAN",
                Date = "2021"
            };
            Console.WriteLine("**********");
            manager.Add(customer);
            manager.Add(student);
            manager.Add(worker);
            manager.Add(robot);
            Console.WriteLine("**********");
        }
    }

    interface IPerson  //soyut
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson  // somut
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmen { get; set; }
    }

    class Worker : IPerson  // somut
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmen { get; set; }
    }
    class Robot : IPerson  // somut
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Date { get; set; }
    }
    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
