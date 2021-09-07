using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignExerciseTwo
{
    public static class DataAccessFactory
    {
        public static IDataAccessable GetDataAccessType()
        {
            Console.Clear();
            Console.WriteLine("Please enter the type of database to access.\nPlease enter \"List\", \"SQL\", or \"Mongo\"\n\n");
            var databaseType = Console.ReadLine();
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
            }
            Console.WriteLine("\nInvalid entry. Please enter \"List\", \"SQL\", or \"Mongo\"\nPress any key to return.\n");
            Console.ReadKey();
            return GetDataAccessType();
        }
    }
}
