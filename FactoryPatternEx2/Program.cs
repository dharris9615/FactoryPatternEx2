using System;
using System.Threading;

namespace FactoryPatternEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool badInput = false;
            string selection = "";

            do {

                Console.Clear();
                badInput = false;

            Console.WriteLine("Please choose a database: \n" +
                "For Mongo Database Access\n" +
                "Type: mongo: \n" +
                "For SQL Database Access\n" +
                "Type: sql: \n" +
                "For List Database Access\n" +
                "Type: list:");
        

            selection = Console.ReadLine();
                if(selection != "sql" && selection != "list" & selection != "mongo")
                {
                    badInput = true;
                    Console.WriteLine("Invalid input try again");
                    Thread.Sleep(1000);
                }


        }while(badInput == true);

            var db = DataAccessFactory.GetDataAccessType(selection);

            var products = db.LoadData();

            Console.Clear();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine();
            }

            db.LoadData();
            db.SaveData();
        }
    }
}
