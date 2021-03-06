using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="YASİN" 
                },
                new Student
                {
                    FirstName="BEYZA"
                },
                new Person
                {
                    FirstName="EREN"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            //Customer customer = new Customer() 
            //{
            //    FirstName="YASİN",
            //    LastName="BULUT",
            //    Id=1,
            //    Departman="JUNİOR DEVELOPER",
            //    City="İSTANBUL"
            //};
            //Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Person2
    {

    }
    class Customer:Person
    {
        public string City { get; set; }
        public string Departman { get; set; }
    }
    class Student : Person
    {
        public string City { get; set; }
    }
}
