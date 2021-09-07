using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignExerciseTwo
{
    class MongoDataAccess : IDataAccessable
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo Database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Database.");
        }

    }
}
