using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static string GetConnectionString(string connectionName)
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static void InitialiseConnections(DatabaseType dB)
        {
            switch (dB)
            {
                case DatabaseType.Sql:
                    SQLConnector sql = new SQLConnector();
                    Connection = sql;
                    break;
            
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
            }
        }
    }
}
