using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new Oracle();
            dataBase.Add();
            dataBase.Delete();
            Console.WriteLine("*******");
            DataBase dataBase1 = new SqlServer();
            dataBase1.Add();
            dataBase1.Delete();

            Console.ReadLine();
        }
    }
    abstract class DataBase
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql Code");
        }
    }
    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle Code");
        }
    }
}
