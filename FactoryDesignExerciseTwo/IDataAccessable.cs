using System.Collections.Generic;

namespace FactoryDesignExerciseTwo
{
    public interface IDataAccessable
    {

        public List<Product> LoadData();
        public void SaveData();


    }
}