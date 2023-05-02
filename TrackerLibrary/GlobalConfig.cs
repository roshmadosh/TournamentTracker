using System.Collections.Generic;
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
    }
}
