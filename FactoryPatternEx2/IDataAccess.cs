using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
    public interface IDataAccess
    {
        public List<Product> LoadData();
        public void SaveData();
    }
}
