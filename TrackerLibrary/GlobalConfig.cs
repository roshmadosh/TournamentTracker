using System.Collections.Generic;
using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }  = new List<IDataConnection>(); 

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                TextConnector sql = new TextConnector();
                Connections.Add(sql);
            }

        }

        public static string ConnectionString(string databaseName)
        {
            string cs = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
            System.Console.WriteLine(cs);
            return cs;
        }
    }
}
