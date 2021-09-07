using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignExerciseTwo
{
    class ListDataAccess : IDataAccessable
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a List Database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Database.");
        }
    }
}
