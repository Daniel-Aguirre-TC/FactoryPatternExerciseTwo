using System;

namespace FactoryDesignExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                var dataAccess = DataAccessFactory.GetDataAccessType();
                Console.WriteLine("\n");
                dataAccess.LoadData();
                Console.ReadLine();
                Console.WriteLine("\n");
                dataAccess.SaveData();
                Console.ReadLine();
            }

        }
    }
}
