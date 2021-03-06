using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }
    class DataBase
    {
        public virtual  void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
        public virtual void Update()
        {
            Console.WriteLine("Update by default");
        }
    }
    class SqlServer:DataBase
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }
    class MySql:DataBase
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySql Code");
            //base.Add();
        }
    }
}
