using System;
namespace FactoryPatternEx2
{
    public static class DataAccessFactory
    {
         static DataAccessFactory()
        {
        }


        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                case "list":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();
            }
        }


    }
}
