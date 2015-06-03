using System;
using System.Configuration;


namespace ConnectDB
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("testing: {0}", System.Configuration.ConfigurationManager.AppSettings["TestKey"]);
            //Console.WriteLine("Enter connection type: ");
            //string input = Console.ReadLine();


            // Valid responses for input is SQL, SQLite and XML 

            IDataSource conn = DataFactory.GetConnectionType();


            conn.ConnectToDataSource();

            Console.WriteLine(conn.ReturnData.ToString());

            Console.WriteLine("----");
            Console.ReadLine();

        }
    }
}
