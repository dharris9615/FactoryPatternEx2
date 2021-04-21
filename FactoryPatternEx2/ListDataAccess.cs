using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }

        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Ipod", Price = 100},
            new Product(){Name = "computer", Price = 300},
            new Product(){Name = "TV", Price = 1000},
            new Product(){Name = "Blender", Price = 50},
            new Product(){Name = "Xbox", Price = 400},
            new Product(){Name = "controller", Price = 70},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from ListData Access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("Accessing your static List");
        }
    }
}
